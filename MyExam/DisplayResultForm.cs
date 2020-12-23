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

namespace MyExam
{
    public partial class DisplayResultForm : Form
    {
        MyExamForm.Exam x;

        public DisplayResultForm()
        {
            InitializeComponent();
        }

        public DisplayResultForm(MyExamForm.Exam Exam)
        {
            InitializeComponent();
            x = Exam;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void DisplayResultForm_Load(object sender, EventArgs e)
        {
            labelCountOfCorrectAnswer.Text = $"Correct =   {x.result.countOfCorrectAnswers}";
            labelCountOfIncorrectAnswer.Text = $"Incorrect = {x.result.countOfFailAnswers.ToString()}";
            labelExamCodeName.Text = $"Exam Code = {x.header.examCode} - {x.header.examTitle}";
            labelExamDate.Text = $"Date =      {x.result.takenDate.ToString("dd/MM/yyyy")}";
            labelFullName.Text = $"Fullname =  {x.result.FullName}";
            labelGrade.Text = $"Grade =     {x.result.grade.ToString()}";

            listViewResult.Columns.Add("QuestionCol","Question Id", 150);
            listViewResult.Columns.Add("ChoiceCol", "Choice Id", 150);
            listViewResult.Columns.Add("ResultCol", "Is Correct", 150);

            string[] arr;
            ListViewItem itm;

            foreach (Response resp in x.result.responses)
            {
                arr = new string[4];
            
                arr[0] = resp.QuestionId?.ToString();
                arr[1] = resp.ChoiceId?.ToString();
                arr[2] = resp.isCorrect.ToString();

                //add items to ListView
                itm = new ListViewItem(arr);

                listViewResult.Items.Add(itm);
            }
        }

        private void listViewResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count <= 0)
                return;

            if (listViewResult.SelectedItems[0].SubItems[0].Text.Length <= 0 || listViewResult.SelectedItems[0].SubItems[1].Text.Length <= 0)
                return;

            QuestionForm Qform = new QuestionForm(x, listViewResult.SelectedItems[0].SubItems[0].Text, listViewResult.SelectedItems[0].SubItems[1].Text);
            Qform.ShowDialog();
        }
    }
}
