using System.Windows.Forms;

namespace MyExam
{
    partial class MyExamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();                
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyExamForm));
            this.btnImportXML = new System.Windows.Forms.Button();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.groupBoxExamTree = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeViewSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemIsMultiSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMultiSelectTrue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMultiSelectFalse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemIsCorrect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemIsCorrectTrue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemIsCorrectFalse = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxXMLNotation = new System.Windows.Forms.GroupBox();
            this.ucXmlRichTextBoxQA = new CustomXmlViewer.ucXmlRichTextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.buttonImportFromDoc = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerDetail = new System.Windows.Forms.SplitContainer();
            this.groupBoxExamTree.SuspendLayout();
            this.contextMenuStripTreeViewSelect.SuspendLayout();
            this.groupBoxXMLNotation.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetail)).BeginInit();
            this.splitContainerDetail.Panel1.SuspendLayout();
            this.splitContainerDetail.Panel2.SuspendLayout();
            this.splitContainerDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportXML
            // 
            this.btnImportXML.Location = new System.Drawing.Point(3, 38);
            this.btnImportXML.Name = "btnImportXML";
            this.btnImportXML.Size = new System.Drawing.Size(338, 31);
            this.btnImportXML.TabIndex = 0;
            this.btnImportXML.Text = "Import XML";
            this.btnImportXML.UseVisualStyleBackColor = true;
            this.btnImportXML.Click += new System.EventHandler(this.btnImportXML_Click);
            // 
            // btnStartExam
            // 
            this.btnStartExam.Location = new System.Drawing.Point(3, 75);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(338, 28);
            this.btnStartExam.TabIndex = 1;
            this.btnStartExam.Text = "Start Exam";
            this.btnStartExam.UseVisualStyleBackColor = true;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // groupBoxExamTree
            // 
            this.groupBoxExamTree.Controls.Add(this.treeView1);
            this.groupBoxExamTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxExamTree.Location = new System.Drawing.Point(0, 0);
            this.groupBoxExamTree.Name = "groupBoxExamTree";
            this.groupBoxExamTree.Size = new System.Drawing.Size(1421, 514);
            this.groupBoxExamTree.TabIndex = 2;
            this.groupBoxExamTree.TabStop = false;
            this.groupBoxExamTree.Text = "Exam Tree";
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStripTreeViewSelect;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(3, 18);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Node1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(1415, 493);
            this.treeView1.ItemHeight = treeView1.ItemHeight + 20;
            this.treeView1.TabIndex = 0;
            this.treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            this.treeView1.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView1_DrawNode);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuStripTreeViewSelect
            // 
            this.contextMenuStripTreeViewSelect.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripTreeViewSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemIsMultiSelect,
            this.toolStripMenuItemIsCorrect});
            this.contextMenuStripTreeViewSelect.Name = "contextMenuStripTreeViewSelect";
            this.contextMenuStripTreeViewSelect.Size = new System.Drawing.Size(163, 52);
            this.contextMenuStripTreeViewSelect.Text = "Select";
            // 
            // toolStripMenuItemIsMultiSelect
            // 
            this.toolStripMenuItemIsMultiSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMultiSelectTrue,
            this.toolStripMenuItemMultiSelectFalse});
            this.toolStripMenuItemIsMultiSelect.Name = "toolStripMenuItemIsMultiSelect";
            this.toolStripMenuItemIsMultiSelect.Size = new System.Drawing.Size(162, 24);
            this.toolStripMenuItemIsMultiSelect.Text = "isMultiSelect";
            // 
            // toolStripMenuItemMultiSelectTrue
            // 
            this.toolStripMenuItemMultiSelectTrue.Name = "toolStripMenuItemMultiSelectTrue";
            this.toolStripMenuItemMultiSelectTrue.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItemMultiSelectTrue.Text = "True";
            this.toolStripMenuItemMultiSelectTrue.Click += new System.EventHandler(this.toolStripMenuItemMultiSelectTrue_Click);
            // 
            // toolStripMenuItemMultiSelectFalse
            // 
            this.toolStripMenuItemMultiSelectFalse.Name = "toolStripMenuItemMultiSelectFalse";
            this.toolStripMenuItemMultiSelectFalse.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItemMultiSelectFalse.Text = "False";
            this.toolStripMenuItemMultiSelectFalse.Click += new System.EventHandler(this.toolStripMenuItemMultiSelectFalse_Click);
            // 
            // toolStripMenuItemIsCorrect
            // 
            this.toolStripMenuItemIsCorrect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemIsCorrectTrue,
            this.toolStripMenuItemIsCorrectFalse});
            this.toolStripMenuItemIsCorrect.Name = "toolStripMenuItemIsCorrect";
            this.toolStripMenuItemIsCorrect.Size = new System.Drawing.Size(162, 24);
            this.toolStripMenuItemIsCorrect.Text = "IsCorrect";
            // 
            // toolStripMenuItemIsCorrectTrue
            // 
            this.toolStripMenuItemIsCorrectTrue.Name = "toolStripMenuItemIsCorrectTrue";
            this.toolStripMenuItemIsCorrectTrue.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItemIsCorrectTrue.Text = "True";
            this.toolStripMenuItemIsCorrectTrue.Click += new System.EventHandler(this.toolStripMenuItemIsCorrectTrue_Click);
            // 
            // toolStripMenuItemIsCorrectFalse
            // 
            this.toolStripMenuItemIsCorrectFalse.Name = "toolStripMenuItemIsCorrectFalse";
            this.toolStripMenuItemIsCorrectFalse.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItemIsCorrectFalse.Text = "False";
            this.toolStripMenuItemIsCorrectFalse.Click += new System.EventHandler(this.toolStripMenuItemIsCorrectFalse_Click);
            // 
            // groupBoxXMLNotation
            // 
            this.groupBoxXMLNotation.Controls.Add(this.ucXmlRichTextBoxQA);
            this.groupBoxXMLNotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxXMLNotation.Location = new System.Drawing.Point(0, 0);
            this.groupBoxXMLNotation.Name = "groupBoxXMLNotation";
            this.groupBoxXMLNotation.Size = new System.Drawing.Size(1421, 404);
            this.groupBoxXMLNotation.TabIndex = 3;
            this.groupBoxXMLNotation.TabStop = false;
            this.groupBoxXMLNotation.Text = "XML Notation";
            // 
            // ucXmlRichTextBoxQA
            // 
            this.ucXmlRichTextBoxQA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucXmlRichTextBoxQA.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucXmlRichTextBoxQA.Location = new System.Drawing.Point(3, 18);
            this.ucXmlRichTextBoxQA.Name = "ucXmlRichTextBoxQA";
            this.ucXmlRichTextBoxQA.Size = new System.Drawing.Size(1415, 383);
            this.ucXmlRichTextBoxQA.TabIndex = 0;
            this.ucXmlRichTextBoxQA.Text = "";
            this.ucXmlRichTextBoxQA.Xml = "";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(3, 106);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(71, 17);
            this.labelFullName.TabIndex = 4;
            this.labelFullName.Text = "Full Name";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(3, 126);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(335, 22);
            this.textBoxFullName.TabIndex = 5;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxFullName_TextChanged);
            // 
            // buttonImportFromDoc
            // 
            this.buttonImportFromDoc.Location = new System.Drawing.Point(3, 3);
            this.buttonImportFromDoc.Name = "buttonImportFromDoc";
            this.buttonImportFromDoc.Size = new System.Drawing.Size(338, 29);
            this.buttonImportFromDoc.TabIndex = 6;
            this.buttonImportFromDoc.Text = "Import from Word";
            this.buttonImportFromDoc.UseVisualStyleBackColor = true;
            this.buttonImportFromDoc.Click += new System.EventHandler(this.buttonImportFromDoc_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonImportFromDoc);
            this.flowLayoutPanel1.Controls.Add(this.btnImportXML);
            this.flowLayoutPanel1.Controls.Add(this.btnStartExam);
            this.flowLayoutPanel1.Controls.Add(this.labelFullName);
            this.flowLayoutPanel1.Controls.Add(this.textBoxFullName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(352, 922);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerDetail);
            this.splitContainerMain.Size = new System.Drawing.Size(1777, 922);
            this.splitContainerMain.SplitterDistance = 352;
            this.splitContainerMain.TabIndex = 8;
            // 
            // splitContainerDetail
            // 
            this.splitContainerDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDetail.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDetail.Name = "splitContainerDetail";
            this.splitContainerDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDetail.Panel1
            // 
            this.splitContainerDetail.Panel1.Controls.Add(this.groupBoxExamTree);
            // 
            // splitContainerDetail.Panel2
            // 
            this.splitContainerDetail.Panel2.Controls.Add(this.groupBoxXMLNotation);
            this.splitContainerDetail.Size = new System.Drawing.Size(1421, 922);
            this.splitContainerDetail.SplitterDistance = 514;
            this.splitContainerDetail.TabIndex = 0;
            // 
            // MyExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 922);
            this.Controls.Add(this.splitContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyExamForm";
            this.Text = "My Exam Main Form";
            this.groupBoxExamTree.ResumeLayout(false);
            this.contextMenuStripTreeViewSelect.ResumeLayout(false);
            this.groupBoxXMLNotation.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerDetail.Panel1.ResumeLayout(false);
            this.splitContainerDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDetail)).EndInit();
            this.splitContainerDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportXML;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.GroupBox groupBoxExamTree;
        private System.Windows.Forms.GroupBox groupBoxXMLNotation;
        private CustomXmlViewer.ucXmlRichTextBox ucXmlRichTextBoxQA;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Button buttonImportFromDoc;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeViewSelect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIsMultiSelect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMultiSelectTrue;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMultiSelectFalse;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIsCorrect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIsCorrectTrue;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIsCorrectFalse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerDetail;
    }
}

