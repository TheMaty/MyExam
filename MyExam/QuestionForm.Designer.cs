namespace MyExam
{
    partial class QuestionForm
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
            this.splitContainerQandA = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelQuestion = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainerForChoicesAndButtons = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQandA)).BeginInit();
            this.splitContainerQandA.Panel1.SuspendLayout();
            this.splitContainerQandA.Panel2.SuspendLayout();
            this.splitContainerQandA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerForChoicesAndButtons)).BeginInit();
            this.splitContainerForChoicesAndButtons.Panel1.SuspendLayout();
            this.splitContainerForChoicesAndButtons.Panel2.SuspendLayout();
            this.splitContainerForChoicesAndButtons.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerQandA
            // 
            this.splitContainerQandA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerQandA.Location = new System.Drawing.Point(0, 0);
            this.splitContainerQandA.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerQandA.Name = "splitContainerQandA";
            this.splitContainerQandA.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerQandA.Panel1
            // 
            this.splitContainerQandA.Panel1.Controls.Add(this.flowLayoutPanelQuestion);
            // 
            // splitContainerQandA.Panel2
            // 
            this.splitContainerQandA.Panel2.Controls.Add(this.splitContainerForChoicesAndButtons);
            this.splitContainerQandA.Size = new System.Drawing.Size(1208, 790);
            this.splitContainerQandA.SplitterDistance = 447;
            this.splitContainerQandA.SplitterWidth = 3;
            this.splitContainerQandA.TabIndex = 0;
            // 
            // flowLayoutPanelQuestion
            // 
            this.flowLayoutPanelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelQuestion.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelQuestion.Name = "flowLayoutPanelQuestion";
            this.flowLayoutPanelQuestion.Size = new System.Drawing.Size(1208, 447);
            this.flowLayoutPanelQuestion.TabIndex = 0;
            // 
            // splitContainerForChoicesAndButtons
            // 
            this.splitContainerForChoicesAndButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerForChoicesAndButtons.Location = new System.Drawing.Point(0, 0);
            this.splitContainerForChoicesAndButtons.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerForChoicesAndButtons.Name = "splitContainerForChoicesAndButtons";
            this.splitContainerForChoicesAndButtons.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerForChoicesAndButtons.Panel1
            // 
            this.splitContainerForChoicesAndButtons.Panel1.Controls.Add(this.flowLayoutPanelAnswers);
            // 
            // splitContainerForChoicesAndButtons.Panel2
            // 
            this.splitContainerForChoicesAndButtons.Panel2.Controls.Add(this.flowLayoutPanelButtons);
            this.splitContainerForChoicesAndButtons.Size = new System.Drawing.Size(1208, 340);
            this.splitContainerForChoicesAndButtons.SplitterDistance = 310;
            this.splitContainerForChoicesAndButtons.SplitterWidth = 3;
            this.splitContainerForChoicesAndButtons.TabIndex = 0;
            // 
            // flowLayoutPanelAnswers
            // 
            this.flowLayoutPanelAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAnswers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAnswers.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAnswers.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelAnswers.Name = "flowLayoutPanelAnswers";
            this.flowLayoutPanelAnswers.Size = new System.Drawing.Size(1208, 310);
            this.flowLayoutPanelAnswers.TabIndex = 0;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonSubmit);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonNext);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonBack);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(1208, 27);
            this.flowLayoutPanelButtons.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1150, 2);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 19);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(1090, 2);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(56, 19);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(1030, 2);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(56, 19);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(970, 2);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(56, 19);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 790);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerQandA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Question Form";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.splitContainerQandA.Panel1.ResumeLayout(false);
            this.splitContainerQandA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQandA)).EndInit();
            this.splitContainerQandA.ResumeLayout(false);
            this.splitContainerForChoicesAndButtons.Panel1.ResumeLayout(false);
            this.splitContainerForChoicesAndButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerForChoicesAndButtons)).EndInit();
            this.splitContainerForChoicesAndButtons.ResumeLayout(false);
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerQandA;
        private System.Windows.Forms.SplitContainer splitContainerForChoicesAndButtons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAnswers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuestion;
    }
}