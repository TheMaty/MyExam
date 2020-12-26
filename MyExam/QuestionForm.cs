using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        Question certainQuestion;
        string choiceIds = string.Empty;
        
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

        public QuestionForm(MyExamForm.Exam Exam, string QuestionId, string ChoiceId)
        {
            InitializeComponent();

            x = Exam;

            certainQuestion = x.qa.Where( item => item.Id == QuestionId ).FirstOrDefault<Question>();
            choiceIds = ChoiceId;
            
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

            if (certainQuestion.question == null)
                LoadQuestion();
            else
                LoadQuestion(certainQuestion, choiceIds);
        }



        private void LoadQuestion(Question question, string choices)
        {
            buttonSubmit.Enabled = false;
            buttonNext.Enabled = false;
            buttonBack.Enabled = false;

            this.buttonCancel.Text = "Close";

            //Clear form
            flowLayoutPanelQuestion.Controls.Clear();
            flowLayoutPanelAnswers.Controls.Clear();

            //generating question
            TextBox txtQuestion = new TextBox();
            txtQuestion.ScrollBars = ScrollBars.Both;
            txtQuestion.Multiline = true;


            PictureBox pBox = new PictureBox();
            pBox.Width = flowLayoutPanelQuestion.Width;
            pBox.Height = flowLayoutPanelQuestion.Height;


            if (question.question.Contains(" *** ")) // there is an image in the question
            {

                int imageStartindex = question.question.IndexOf(" *** ");
                int imageEndIndex = question.question.LastIndexOf(" *** ");

                txtQuestion.Text = question.Id + " - " + question.question.Remove(imageStartindex, imageEndIndex - imageStartindex);
                txtQuestion.Width = flowLayoutPanelQuestion.Width;
                txtQuestion.Height = Convert.ToInt32(flowLayoutPanelQuestion.Height * 0.25);
                //inserting text to the form
                flowLayoutPanelQuestion.Controls.Add(txtQuestion);

                byte[] bImage = Convert.FromBase64String(question.question.Substring(imageStartindex, imageEndIndex - imageStartindex).Replace(" *** ", ""));

                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                pBox.Image = (Image)converter.ConvertFrom(bImage);
                pBox.Width = flowLayoutPanelQuestion.Width;
                pBox.Height = Convert.ToInt32(flowLayoutPanelQuestion.Height * 0.75);
                //inserting image to the form
                flowLayoutPanelQuestion.Controls.Add(pBox);



            }
            else
            {
                txtQuestion.Text = question.Id + " - " + question.question;
                txtQuestion.Width = flowLayoutPanelQuestion.Width;
                txtQuestion.Height = flowLayoutPanelQuestion.Height;

                //inserting to the form
                flowLayoutPanelQuestion.Controls.Add(txtQuestion);
            }

            //answers are generating
            if (question.allowMultipleSelect)
            {
                //use check box control
                foreach (MyExamForm.Choice choice in question.choices)
                {
                    if (choiceIds.Contains(choice.Id))
                        flowLayoutPanelAnswers.Controls.Add(new CheckBox() { Text = choice.answerText, Name = choice.Id + "-" + choice.isCorrect, Width = flowLayoutPanelAnswers.Width, Checked = true });
                    else
                        flowLayoutPanelAnswers.Controls.Add(new CheckBox() { Text = choice.answerText, Name = choice.Id + "-" + choice.isCorrect, Width = flowLayoutPanelAnswers.Width });

                }
            }
            else
            {
                //use radio control
                foreach (MyExamForm.Choice choice in question.choices)
                {
                    if (choiceIds.Contains(choice.Id))
                        flowLayoutPanelAnswers.Controls.Add(new RadioButton() { Text = choice.answerText, Name = choice.Id + "-" + choice.isCorrect, Width = flowLayoutPanelAnswers.Width, Checked = true });
                    else
                        flowLayoutPanelAnswers.Controls.Add(new RadioButton() { Text = choice.answerText, Name = choice.Id + "-" + choice.isCorrect, Width = flowLayoutPanelAnswers.Width });
                }
            }
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
            txtQuestion.ScrollBars = ScrollBars.Both;
            txtQuestion.Multiline = true;


            PictureBox pBox = new PictureBox();
            pBox.Width = flowLayoutPanelQuestion.Width;
            pBox.Height = flowLayoutPanelQuestion.Height;

    
            if (x.qa[currentItem].question.Contains(" *** ")) // there is an image in the question
            {

                int imageStartindex = x.qa[currentItem].question.IndexOf(" *** ");
                int imageEndIndex = x.qa[currentItem].question.LastIndexOf(" *** ");

                txtQuestion.Text = (currentItem + 1) + " of " + x.qa.Count + " - " + x.qa[currentItem].question.Remove(imageStartindex, imageEndIndex - imageStartindex);
                txtQuestion.Width = flowLayoutPanelQuestion.Width;
                txtQuestion.Height =  Convert.ToInt32(flowLayoutPanelQuestion.Height * 0.25);
                //inserting text to the form
                flowLayoutPanelQuestion.Controls.Add(txtQuestion);

                byte[] bImage= Convert.FromBase64String(x.qa[currentItem].question.Substring(imageStartindex, imageEndIndex - imageStartindex).Replace(" *** ", ""));

                System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                pBox.Image = (Image)converter.ConvertFrom(bImage);
                pBox.Width = flowLayoutPanelQuestion.Width;
                pBox.Height = Convert.ToInt32(flowLayoutPanelQuestion.Height * 0.75);
                //inserting image to the form
                flowLayoutPanelQuestion.Controls.Add(pBox);
              

             
            }
            else
            {
                txtQuestion.Text = (currentItem + 1) + " of " + x.qa.Count + " - " + x.qa[currentItem].question;
                txtQuestion.Width = flowLayoutPanelQuestion.Width;
                txtQuestion.Height = flowLayoutPanelQuestion.Height;

                //inserting to the form
                flowLayoutPanelQuestion.Controls.Add(txtQuestion);
            }

            //answers are generating
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
            if (certainQuestion.question == null)
                ((MyExamForm)this.Owner).exam = x;
            
            this.Close();
            this.Dispose();
        }
    }
}
