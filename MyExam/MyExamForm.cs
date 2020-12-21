using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Office;

namespace MyExam
{
    public partial class MyExamForm : Form
    {
        public struct Header
        {
            public string examCode;
            public string examTitle;
        }

        public struct Choice
        {
            public string Id;
            public bool isCorrect;
            public string answerText;
        }
        public struct Question
        {
            public string Id;
            public string question;
            public int point;
            public List<Choice> choices;
            public bool allowMultipleSelect;
        }

        public struct Response
        {
            public string QuestionId;
            public string ChoiceId;
            public bool isCorrect;
        }
        public struct Result
        {
            public string FullName;
            public DateTime takenDate;
            public int countOfCorrectAnswers;
            public int countOfFailAnswers;
            public int grade;
            public List<Response> responses;

        }

        public struct Exam
        {
            public Header header;
            public List<Question> qa;
            public Result result;
        }

        public Exam exam;

        // Create a Font object for the node tags.
        Font tagFont = new Font("Helvetica", 8, FontStyle.Bold);

        public MyExamForm()
        {
            InitializeComponent();
            ucXmlRichTextBoxQA.PropertyChanged += UcXmlRichTextBoxQA_PropertyChanged;
            ucXmlRichTextBoxQA.Xml = System.IO.File.ReadAllText(@"C:\source\repos\MyExam\MyExam\Resources\QATemplate.xml");
        }


        private void UcXmlRichTextBoxQA_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            readQAXML();
            refreshTreeView();
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            exam.result.countOfCorrectAnswers = 0;
            exam.result.countOfFailAnswers = 0;
            exam.result.grade = 0;

            //FullName is mandatory            
            if (textBoxFullName.TextLength <= 0 || !(Regex.Match(textBoxFullName.Text, @"[A-Za-z0-9\-]+").Success))
            {
                MessageBox.Show("You should set Exam Taker Full Name before test start", "Fullname is mandatory");
                return;
            }
            generateExamFormAndCollectResponses();
        }

        private void readQAXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(ucXmlRichTextBoxQA.Text);
            XmlNode node;

            //Create an Exam
            exam = new Exam();

            //get code and title
            Header header = new Header();
            node = doc.SelectSingleNode("Exam");

            header.examCode = node.Attributes["Code"]?.InnerText;
            header.examTitle = node.Attributes["Title"]?.InnerText;

            exam.header = header;

            exam.result = new Result();
            exam.result.FullName = textBoxFullName.Text;
            exam.result.responses = new List<Response>();
            exam.result.takenDate = DateTime.Today;

            exam.qa = new List<Question>();

            //load Questions
            foreach (XmlNode nodeQuestion in doc.GetElementsByTagName("Question"))
            {
                Question q = new Question();
                q.Id = nodeQuestion.Attributes["Id"]?.InnerText;
                q.point = int.Parse(nodeQuestion.Attributes["Point"]?.InnerText);
                q.allowMultipleSelect = nodeQuestion.Attributes["isMultiSelect"]?.InnerText == "True" ? true : false;
                q.question = nodeQuestion.Attributes["Text"]?.InnerText;

                q.choices = new List<Choice>();
                //load Choices
                foreach (XmlNode nodeChoice in nodeQuestion.ChildNodes)
                {
                    if (nodeChoice.Attributes == null)
                        continue;

                    Choice c = new Choice();
                    c.Id = nodeChoice.Attributes["Id"]?.InnerText;
                    bool.TryParse(nodeChoice.Attributes["isCorrect"].InnerText, out c.isCorrect);
                    c.answerText = nodeChoice.InnerText;

                    q.choices.Add(c);
                }
                exam.qa.Add(q);

                //create correspondent response
                exam.result.responses.Add(new Response());
            }


        }

        private void generateExamFormAndCollectResponses()
        {
            QuestionForm Qform = new QuestionForm(exam);
            Qform.ShowDialog(this);

            DisplayResultForm DRForm = new DisplayResultForm(exam);
            DRForm.ShowDialog();

        }

        private void buttonImportFromDoc_Click(object sender, EventArgs e)
        {

            object filename = @"C:\Users\eatamuh\source\repos\MyExam\MyExam\Resources\Exam MB2-715 for Import.docx";

            Microsoft.Office.Interop.Word.ApplicationClass AC = new Microsoft.Office.Interop.Word.ApplicationClass();
            Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();

            object readOnly = false;
            object isVisible = true;
            object missing = System.Reflection.Missing.Value;
            try
            {
                doc = AC.Documents.Open(ref filename, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref isVisible, ref missing, ref missing, ref missing);
                
                ucXmlRichTextBoxQA.Xml = System.IO.File.ReadAllText(generateQAXMLforExam_MB2_715_for_Import_docx(Regex.Replace(doc.Content.Text, @"\r\n?|\n?|\v?|\f", "")));               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error is occured", MessageBoxButtons.OK);
            }
            finally
            {
                object doNotSaveChanges = Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges;
                doc.Close(ref doNotSaveChanges, ref missing, ref missing);
                AC.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(AC);
                GC.Collect();
            }           
        }

        private string generateQAXMLforExam_MB2_716_questions_formatted_docx(string str)
        {
            int counter = 0;
            string strTemp = str;
            string strCodeName = str.Split(new[] { "Title :" }, StringSplitOptions.None)[0];
            strTemp = "Title :" + str.Split(new[] { "Title :" }, StringSplitOptions.None)[1];
            string strExamName = strTemp.Split(new[] { "NO.1 " }, StringSplitOptions.None)[0];
            strTemp = strTemp.Split(new[] { "NO.1 " }, StringSplitOptions.None)[1];
            strTemp = "NO.1" + strTemp;
            string[] Questions = strTemp.Split(new[] { "NO." }, StringSplitOptions.None);
            
            XElement element = new XElement("Exam",
                    new XAttribute("Code", strCodeName),
                    new XAttribute("Title", strExamName)
                    );
            
            foreach(string q in Questions)
            {
                if (q == string.Empty)
                    continue;

                XElement sub = new XElement("Question",
                    new XAttribute("Id", counter.ToString()),
                    new XAttribute("Point",1),
                    new XAttribute("isMultiSelect","False"),
                    new XAttribute("Text", q.Split(new[] { "A." }, StringSplitOptions.None)[0])
                    );

                string temp = q.Split(new[] { "A." }, StringSplitOptions.None)[1];

                XElement choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "A"),
                    new XAttribute("isCorrect", "False")
                    );

                choiceLevel.Value = temp.Split(new[] { "B." }, StringSplitOptions.None)[0];

                temp = temp.Split(new[] { "B." }, StringSplitOptions.None)[1];

                sub.Add(choiceLevel);

                choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "B"),
                    new XAttribute("isCorrect", "False")
                    );

                choiceLevel.Value = temp.Split(new[] { "C." }, StringSplitOptions.None)[0];

                temp = temp.Split(new[] { "C." }, StringSplitOptions.None)[1];

                sub.Add(choiceLevel);


                choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "C"),
                    new XAttribute("isCorrect", "False")
                    );

                choiceLevel.Value = temp.Split(new[] { "D." }, StringSplitOptions.None)[0];

                temp = temp.Split(new[] { "D." }, StringSplitOptions.None)[1];

                sub.Add(choiceLevel);


                choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "D"),
                    new XAttribute("isCorrect", "False")
                    );

                if (temp.Split(new[] { "E." }, StringSplitOptions.None).Length > 1)
                {
                    choiceLevel.Value = temp.Split(new[] { "E." }, StringSplitOptions.None)[0];

                    choiceLevel = new XElement("Choice",
                        new XAttribute("Id", "E"),
                        new XAttribute("isCorrect", "False")
                        );

                    choiceLevel.Value = temp;
                    sub.Add(choiceLevel);

                }
                else
                {
                    choiceLevel.Value = temp;
                    sub.Add(choiceLevel);
                }

                element.Add(sub);
                counter++;
            }


            XDocument doc = new XDocument(element);


            doc.Save($"{strCodeName.Replace(":","")}.xml");

            return $"{strCodeName.Replace(":", "")}.xml";

            //new XDocument(
            //    new XElement("Exam",
            //        new XElement("someNode", "someValue")
            //    )
            //).Save("foo.xml");
        }
        private string generateQAXMLforExam_MB2_718_questions_formatted_docx(string str)
        {
            int counter = 0;
            string strTemp = str;
            string strCodeName = str.Split(new[] { "Title :" }, StringSplitOptions.None)[0];
            strTemp = "Title :" + str.Split(new[] { "Title :" }, StringSplitOptions.None)[1];
            string strExamName = strTemp.Split(new[] { "1" }, StringSplitOptions.None)[0];

            string[] Questions = strTemp.Replace("Title : Microsoft Dynamics 365 Customer Service1","").Split(new[] { " * " }, StringSplitOptions.None);
            
        
            XElement element = new XElement("Exam",
                    new XAttribute("Code", strCodeName),
                    new XAttribute("Title", strExamName)
                    );

            foreach (string q in Questions)
            {
                if (q == string.Empty)
                    continue;
                //clean up the string
                string mainPart = q.Split(new[] { "Answer" }, StringSplitOptions.None)[0];
          

                XElement sub = new XElement("Question",
                    new XAttribute("Id", counter.ToString()),
                    new XAttribute("Point", 1),
                    new XAttribute("isMultiSelect", "False"),
                    new XAttribute("Text", mainPart.Split(new[] { "A." }, StringSplitOptions.None)[0])
                    );

                string temp = mainPart.Split(new[] { "A." }, StringSplitOptions.None)[1];

                XElement choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "A"),
                    new XAttribute("isCorrect", "False")
                    );

                choiceLevel.Value = temp.Split(new[] { "B." }, StringSplitOptions.None)[0];

                temp = temp.Split(new[] { "B." }, StringSplitOptions.None)[1];

                sub.Add(choiceLevel);

                choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "B"),
                    new XAttribute("isCorrect", "False")
                    );

                choiceLevel.Value = temp.Split(new[] { "C." }, StringSplitOptions.None)[0];

                temp = temp.Split(new[] { "C." }, StringSplitOptions.None)[1];

                sub.Add(choiceLevel);


                choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "C"),
                    new XAttribute("isCorrect", "False")
                    );

                choiceLevel.Value = temp.Split(new[] { "D." }, StringSplitOptions.None)[0];

                temp = temp.Split(new[] { "D." }, StringSplitOptions.None)[1];

                sub.Add(choiceLevel);


                choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "D"),
                    new XAttribute("isCorrect", "False")
                    );

                if (temp.Split(new[] { "E." }, StringSplitOptions.None).Length > 1)
                {
                    choiceLevel.Value = temp.Split(new[] { "E." }, StringSplitOptions.None)[0];

                    temp = temp.Split(new[] { "E." }, StringSplitOptions.None)[1];

                    sub.Add(choiceLevel);


                    choiceLevel = new XElement("Choice",
                       new XAttribute("Id", "E"),
                       new XAttribute("isCorrect", "False")
                       );                                  

                    if (temp.Split(new[] { "F." }, StringSplitOptions.None).Length > 1)
                    {
                        choiceLevel.Value = temp.Split(new[] { "F." }, StringSplitOptions.None)[0];
                        sub.Add(choiceLevel);

                        choiceLevel = new XElement("Choice",
                          new XAttribute("Id", "F"),
                          new XAttribute("isCorrect", "False")
                          );

                        choiceLevel.Value = temp.Split(new[] { "F." }, StringSplitOptions.None)[1];                        
                        sub.Add(choiceLevel);
                    }
                    else
                    {
                        choiceLevel.Value = temp;
                        sub.Add(choiceLevel);
                    }

                }          
                else
                {
                    choiceLevel.Value = temp;
                    sub.Add(choiceLevel);
                }

                element.Add(sub);
                counter++;
            }


            XDocument doc = new XDocument(element);


            doc.Save($"{strCodeName.Replace(":", "")}.xml");

            return $"{strCodeName.Replace(":", "")}.xml";

            //new XDocument(
            //    new XElement("Exam",
            //        new XElement("someNode", "someValue")
            //    )
            //).Save("foo.xml");
        }

        private string generateQAXMLforExam_MB2_715_for_Import_docx(string str)
        {
            int counter = 0;
            string strCodeName = "Exam MB2-715";
            string strExamName = "Title : Certification Microsoft Dynamics 365 Customer Engagement Online Deployment";

            string[] Questions = str.Split(new[] { " * - " }, StringSplitOptions.None);


            XElement element = new XElement("Exam",
                    new XAttribute("Code", strCodeName),
                    new XAttribute("Title", strExamName)
                    );

            foreach (string q in Questions)
            {
                if (q == string.Empty)
                    continue;
                //clean up the string
                string mainPart = q.Split(new[] { "Answer" }, StringSplitOptions.None)[0];


                XElement sub = new XElement("Question",
                    new XAttribute("Id", counter.ToString()),
                    new XAttribute("Point", 1),
                    new XAttribute("isMultiSelect", "False"),
                    new XAttribute("Text", mainPart.Split(new[] { "A." }, StringSplitOptions.None)[0])
                    );

                string temp = mainPart.Split(new[] { "A." }, StringSplitOptions.None)[1];

                XElement choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "A"),
                    new XAttribute("isCorrect", "False")
                    );

                choiceLevel.Value = temp.Split(new[] { "B." }, StringSplitOptions.None)[0];

                temp = temp.Split(new[] { "B." }, StringSplitOptions.None)[1];

                sub.Add(choiceLevel);

                choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "B"),
                    new XAttribute("isCorrect", "False")
                    );

                choiceLevel.Value = temp.Split(new[] { "C." }, StringSplitOptions.None)[0];

                temp = temp.Split(new[] { "C." }, StringSplitOptions.None)[1];

                sub.Add(choiceLevel);


                choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "C"),
                    new XAttribute("isCorrect", "False")
                    );

                choiceLevel.Value = temp.Split(new[] { "D." }, StringSplitOptions.None)[0];

                temp = temp.Split(new[] { "D." }, StringSplitOptions.None)[1];

                sub.Add(choiceLevel);


                choiceLevel = new XElement("Choice",
                    new XAttribute("Id", "D"),
                    new XAttribute("isCorrect", "False")
                    );

                if (temp.Split(new[] { "E." }, StringSplitOptions.None).Length > 1)
                {
                    choiceLevel.Value = temp.Split(new[] { "E." }, StringSplitOptions.None)[0];

                    temp = temp.Split(new[] { "E." }, StringSplitOptions.None)[1];

                    sub.Add(choiceLevel);


                    choiceLevel = new XElement("Choice",
                       new XAttribute("Id", "E"),
                       new XAttribute("isCorrect", "False")
                       );

                    if (temp.Split(new[] { "F." }, StringSplitOptions.None).Length > 1)
                    {
                        choiceLevel.Value = temp.Split(new[] { "F." }, StringSplitOptions.None)[0];
                        sub.Add(choiceLevel);

                        choiceLevel = new XElement("Choice",
                          new XAttribute("Id", "F"),
                          new XAttribute("isCorrect", "False")
                          );

                        choiceLevel.Value = temp.Split(new[] { "F." }, StringSplitOptions.None)[1];
                        sub.Add(choiceLevel);
                    }
                    else
                    {
                        choiceLevel.Value = temp;
                        sub.Add(choiceLevel);
                    }

                }
                else
                {
                    choiceLevel.Value = temp;
                    sub.Add(choiceLevel);
                }

                element.Add(sub);
                counter++;
            }


            XDocument doc = new XDocument(element);


            doc.Save($"{strCodeName.Replace(":", "")}.xml");

            return $"{strCodeName.Replace(":", "")}.xml";
        }

        private string generateQAXML()
        {
            XElement element = new XElement("Exam",
                    new XAttribute("Code", exam.header.examCode),
                    new XAttribute("Title", exam.header.examTitle)
                    );

            foreach (Question q in exam.qa)
            {
                XElement sub = new XElement("Question",
                    new XAttribute("Id", q.Id),
                    new XAttribute("Point", q.point),
                    new XAttribute("isMultiSelect", q.allowMultipleSelect.ToString()),
                    new XAttribute("Text", q.question)
                    );

                foreach (Choice c in q.choices)
                {

                    XElement choiceLevel = new XElement("Choice",
                        new XAttribute("Id", c.Id),
                        new XAttribute("isCorrect", c.isCorrect)
                        );

                    choiceLevel.Value = c.answerText;
                    sub.Add(choiceLevel);
                }

                element.Add(sub);
            }


            XDocument doc = new XDocument(element);


            doc.Save($"{exam.header.examCode.Replace(":", "")}.xml");

            return $"{exam.header.examCode.Replace(":", "")}.xml";
        }

        private void btnImportXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogLoadXML = new OpenFileDialog();
            if (openFileDialogLoadXML.ShowDialog() == DialogResult.OK)
                ucXmlRichTextBoxQA.Xml = System.IO.File.ReadAllText(openFileDialogLoadXML.FileName);
        }

        private void refreshTreeView()
        {
            if (exam.qa == null)
                return;

            TreeNode selectedNode = treeView1.SelectedNode;

            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(exam.header.examCode);
            foreach (Question q in exam.qa)
            {
                TreeNode node = treeView1.Nodes[0].Nodes.Add("q_" + q.Id, q.question + " (  is Multiple selection : " + q.allowMultipleSelect.ToString() + " ) " );
                node.ToolTipText = q.question + " ( is Multiple selection : " + q.allowMultipleSelect.ToString() + " ) ";

                foreach (Choice c in q.choices)
                {
                    node.Nodes.Add("c_" + c.Id, c.answerText + " ( " + c.isCorrect.ToString() + " ) ").ToolTipText = c.answerText + " ( " + c.isCorrect.ToString() + " ) ";
                }
            }

            treeView1.ExpandAll();

            if (treeView1.Nodes.Count > 0 && selectedNode != null)
                findNodeToBeSelectedRecursively(treeView1.Nodes[0], selectedNode.Text);

            treeView1.Refresh();

        }

        private void findNodeToBeSelectedRecursively(TreeNode tnode, string searchtext)
        {
            foreach(TreeNode tn in tnode.Nodes)
            {
                if (tn.Text == searchtext)
                    treeView1.SelectedNode = tn;
                else
                    findNodeToBeSelectedRecursively(tn, searchtext);
            }
        }

        private void refreshXML()
        {
            ucXmlRichTextBoxQA.Xml = System.IO.File.ReadAllText(generateQAXML());
        }


        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.SelectedNode = e.Node;

            if (e.Button == MouseButtons.Right)
            {

                if (treeView1.SelectedNode != null)
                {
                    if (treeView1.SelectedNode.Name.Contains("q_"))
                    {
                        //question
                        contextMenuStripTreeViewSelect.Items[0].Enabled = true;
                        contextMenuStripTreeViewSelect.Items[1].Enabled = false;
                    }
                    else
                    {
                        //response
                        contextMenuStripTreeViewSelect.Items[0].Enabled = false;
                        contextMenuStripTreeViewSelect.Items[1].Enabled = true;
                    }
                }
            }
        }

        private void toolStripMenuItemMultiSelectTrue_Click(object sender, EventArgs e)
        {
            var qIndex = exam.qa.FindIndex(x => x.Id == treeView1.SelectedNode.Name.Split('_')[1]);

            Question qTemp = new Question()
            {
                allowMultipleSelect = true,
                Id = exam.qa[qIndex].Id,
                point = exam.qa[qIndex].point,
                question = exam.qa[qIndex].question,
                choices = exam.qa[qIndex].choices
            };

            exam.qa[qIndex] = qTemp;

            refreshXML();
        }

        private void toolStripMenuItemMultiSelectFalse_Click(object sender, EventArgs e)
        {
            var qIndex = exam.qa.FindIndex(x => x.Id == treeView1.SelectedNode.Name.Split('_')[1]);

            Question qTemp = new Question()
            {
                allowMultipleSelect = false,
                Id = exam.qa[qIndex].Id,
                point = exam.qa[qIndex].point,
                question = exam.qa[qIndex].question,
                choices = exam.qa[qIndex].choices
            };

            exam.qa[qIndex] = qTemp;

            refreshXML();
        }

        private void toolStripMenuItemIsCorrectTrue_Click(object sender, EventArgs e)
        {            
            var qIndex = exam.qa.FindIndex(x => x.Id == treeView1.SelectedNode.Parent.Name.Split('_')[1]);
            var cIndex = exam.qa[qIndex].choices.FindIndex(x => x.Id == treeView1.SelectedNode.Name.Split('_')[1]);

            Choice cTemp = new Choice()
            {
                Id = exam.qa[qIndex].choices[cIndex].Id,
                answerText = exam.qa[qIndex].choices[cIndex].answerText,
                isCorrect = true
            };

            exam.qa[qIndex].choices[cIndex] = cTemp;

            refreshXML();
        }

        private void toolStripMenuItemIsCorrectFalse_Click(object sender, EventArgs e)
        {
            var qIndex = exam.qa.FindIndex(x => x.Id == treeView1.SelectedNode.Parent.Name.Split('_')[1]);
            var cIndex = exam.qa[qIndex].choices.FindIndex(x => x.Id == treeView1.SelectedNode.Name.Split('_')[1]);

            Choice cTemp = new Choice()
            {
                Id = exam.qa[qIndex].choices[cIndex].Id,
                answerText = exam.qa[qIndex].choices[cIndex].answerText,
                isCorrect = false
            };

            exam.qa[qIndex].choices[cIndex] = cTemp;

            refreshXML();
        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
            exam.result.FullName = textBoxFullName.Text;
        }



        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            Rectangle rectNodeBounds = e.Node.Bounds;
            rectNodeBounds.Width = (int)(rectNodeBounds.Width * 0.8);

            // Draw the background and node text for a selected node.
            if ((e.State & TreeNodeStates.Selected) != 0)
            {              
                // Draw the background of the selected node. The NodeBounds
                // method makes the highlight rectangle large enough to
                // include the text of a node tag, if one is present.
                //e.Graphics.FillRectangle(Brushes.DarkBlue, rectNodeBounds);

                // Retrieve the node font. If the node font has not been set,
                // use the TreeView font.
                Font nodeFont = e.Node.NodeFont;
                if (nodeFont == null) nodeFont = ((TreeView)sender).Font;

                // Draw the node text.
                e.Graphics.DrawString(e.Node.Text, nodeFont, Brushes.White,
                    Rectangle.Inflate(rectNodeBounds, 2, 0));
            }

            // Use the default background and node text.
            else
            {
                e.DrawDefault = true;
            }          
        }
    }
}
