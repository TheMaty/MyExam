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
            this.splitContainerQandA.Size = new System.Drawing.Size(1620, 481);
            this.splitContainerQandA.SplitterDistance = 142;
            this.splitContainerQandA.TabIndex = 0;
            // 
            // flowLayoutPanelQuestion
            // 
            this.flowLayoutPanelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelQuestion.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelQuestion.Name = "flowLayoutPanelQuestion";
            this.flowLayoutPanelQuestion.Size = new System.Drawing.Size(1620, 142);
            this.flowLayoutPanelQuestion.TabIndex = 0;
            // 
            // splitContainerForChoicesAndButtons
            // 
            this.splitContainerForChoicesAndButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerForChoicesAndButtons.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainerForChoicesAndButtons.Size = new System.Drawing.Size(1620, 335);
            this.splitContainerForChoicesAndButtons.SplitterDistance = 258;
            this.splitContainerForChoicesAndButtons.TabIndex = 0;
            // 
            // flowLayoutPanelAnswers
            // 
            this.flowLayoutPanelAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAnswers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAnswers.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAnswers.Name = "flowLayoutPanelAnswers";
            this.flowLayoutPanelAnswers.Size = new System.Drawing.Size(1620, 258);
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
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(1620, 73);
            this.flowLayoutPanelButtons.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1542, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(1461, 3);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(1380, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1299, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 481);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerQandA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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