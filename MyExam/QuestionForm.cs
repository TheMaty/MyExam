using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyExam.MyExamForm;

//if no answer is given system supposes result as True

namespace MyExam
{
    public partial class QuestionForm : Form
    {       
        MyExamForm.Exam x;
        int currentItem = 0;
        public QuestionForm()
        {
            InitializeComponent();
        }

        public QuestionForm(MyExamForm.Exam Exam)
        {
            InitializeComponent();
            x = Exam;
            x.qa = ShuffleList(x.qa);

            for(int i=0; i<x.qa.Count; i++)
            {
                Question qTemp = x.qa[i];
                qTemp.choices = ShuffleList(qTemp.choices);
                x.qa[i] = qTemp;
            }
        }

        private List<E> ShuffleList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            this.Name = $"{x.header.examCode} - {x.header.examTitle}";
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (currentItem >= x.qa.Count)
            {
                buttonSubmit.Enabled = true;
                buttonNext.Enabled = false;                 
                return;
            }
            else
            {
                buttonSubmit.Enabled = false;
                buttonNext.Enabled = true;
            }

            if (currentItem <= 0 )
            {
                buttonSubmit.Enabled = false;
                buttonBack.Enabled = false;
                if (currentItem < 0 )
                    return;
            }
            else
            {
                buttonSubmit.Enabled = false;
                buttonBack.Enabled = true;
            }

            //Clear form
            flowLayoutPanelQuestion.Controls.Clear();
            flowLayoutPanelAnswers.Controls.Clear();

            //generating question
            TextBox txtQuestion = new TextBox();
            txtQuestion.Text = x.qa[currentItem].question;
            txtQuestion.Multiline = true;
            txtQuestion.Width = flowLayoutPanelQuestion.Width;
            txtQuestion.Height = flowLayoutPanelQuestion.Height;
            txtQuestion.ScrollBars = ScrollBars.Both;

            //inserting to the form
            flowLayoutPanelQuestion.Controls.Add(txtQuestion);

            //answres are generating
            if (x.qa[currentItem].allowMultipleSelect)
            {
                //use check box control
                foreach (MyExamForm.Choice choice in x.qa[currentItem].choices)
                {
                    flowLayoutPanelAnswers.Controls.Add(new CheckBox() { Text = choice.answerText, Name = choice.Id + "-" + choice.isCorrect, Width = flowLayoutPanelAnswers.Width });
                }
            }
            else
            {
                //use radio control
                foreach (MyExamForm.Choice choice in x.qa[currentItem].choices)
                {
                    flowLayoutPanelAnswers.Controls.Add(new RadioButton() { Text = choice.answerText, Name = choice.Id + "-" + choice.isCorrect, Width = flowLayoutPanelAnswers.Width});
                }
            }
        }

        private void collectAnswer()
        {
            string choiceId = "";

            if (x.qa[currentItem].allowMultipleSelect)
            {
                bool isCorrect = true;
                //find selected answer of check box 
                foreach (Control control in flowLayoutPanelAnswers.Controls)
                {
                    CheckBox button = (CheckBox)control;

                    if (button.Checked != bool.Parse(button.Name.Split('-')[1]))
                        isCorrect = isCorrect && false;

                    if (button.Checked)
                        choiceId += button.Name.Split('-')[0] + ";";
                }

                x.result.responses[currentItem] = new Response() { QuestionId = x.qa[currentItem].Id, isCorrect = isCorrect, ChoiceId = choiceId };
            }
            else
            {
                bool isCorrect = false;
                //find selected answer of radio button
                foreach (Control control in flowLayoutPanelAnswers.Controls)
                {
                    RadioButton button = (RadioButton)control;
                    if (button.Checked)
                    {
                        if (bool.Parse(button.Name.Split('-')[1]))
                            isCorrect = true;
                        choiceId = button.Name.Split('-')[0];
                        break;
                    }
                }

                x.result.responses[currentItem] = new Response() { QuestionId = x.qa[currentItem].Id, isCorrect = isCorrect, ChoiceId = choiceId };
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            collectAnswer();

            currentItem++;
            LoadQuestion();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            collectAnswer();

            currentItem--;
            LoadQuestion();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //start calculation
            foreach(Response resp in x.result.responses)
            {
                if (resp.isCorrect)
                {
                    x.result.countOfCorrectAnswers++;
                    x.result.grade += x.qa.FirstOrDefault(x => x.Id == resp.QuestionId).point;
                }
                else
                    x.result.countOfFailAnswers++;
            }
            ((MyExamForm)this.Owner).exam = x;
            this.Close();
            this.Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ((MyExamForm)this.Owner).exam = x;
            this.Close();
            this.Dispose();
        }
    }
}
