﻿using System.Windows.Forms;

namespace MyExam
{
    partial class DisplayResultForm
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerHeader = new System.Windows.Forms.SplitContainer();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelExamCodeName = new System.Windows.Forms.Label();
            this.labelExamDate = new System.Windows.Forms.Label();
            this.labelCountOfIncorrectAnswer = new System.Windows.Forms.Label();
            this.labelCountOfCorrectAnswer = new System.Windows.Forms.Label();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).BeginInit();
            this.splitContainerHeader.Panel1.SuspendLayout();
            this.splitContainerHeader.Panel2.SuspendLayout();
            this.splitContainerHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerHeader);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.buttonOK);
            this.splitContainerMain.Size = new System.Drawing.Size(969, 768);
            this.splitContainerMain.SplitterDistance = 713;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerHeader
            // 
            this.splitContainerHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHeader.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHeader.Name = "splitContainerHeader";
            this.splitContainerHeader.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHeader.Panel1
            // 
            this.splitContainerHeader.Panel1.Controls.Add(this.labelGrade);
            this.splitContainerHeader.Panel1.Controls.Add(this.labelFullName);
            this.splitContainerHeader.Panel1.Controls.Add(this.labelExamCodeName);
            this.splitContainerHeader.Panel1.Controls.Add(this.labelExamDate);
            this.splitContainerHeader.Panel1.Controls.Add(this.labelCountOfIncorrectAnswer);
            this.splitContainerHeader.Panel1.Controls.Add(this.labelCountOfCorrectAnswer);
            // 
            // splitContainerHeader.Panel2
            // 
            this.splitContainerHeader.Panel2.Controls.Add(this.listViewResult);
            this.splitContainerHeader.Size = new System.Drawing.Size(969, 713);
            this.splitContainerHeader.SplitterDistance = 131;
            this.splitContainerHeader.TabIndex = 1;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(12, 103);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(46, 17);
            this.labelGrade.TabIndex = 5;
            this.labelGrade.Text = "label1";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(12, 52);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(46, 17);
            this.labelFullName.TabIndex = 4;
            this.labelFullName.Text = "label1";
            // 
            // labelExamCodeName
            // 
            this.labelExamCodeName.AutoSize = true;
            this.labelExamCodeName.Location = new System.Drawing.Point(12, 35);
            this.labelExamCodeName.Name = "labelExamCodeName";
            this.labelExamCodeName.Size = new System.Drawing.Size(46, 17);
            this.labelExamCodeName.TabIndex = 3;
            this.labelExamCodeName.Text = "label1";
            // 
            // labelExamDate
            // 
            this.labelExamDate.AutoSize = true;
            this.labelExamDate.Location = new System.Drawing.Point(12, 18);
            this.labelExamDate.Name = "labelExamDate";
            this.labelExamDate.Size = new System.Drawing.Size(46, 17);
            this.labelExamDate.TabIndex = 2;
            this.labelExamDate.Text = "label1";
            // 
            // labelCountOfIncorrectAnswer
            // 
            this.labelCountOfIncorrectAnswer.AutoSize = true;
            this.labelCountOfIncorrectAnswer.Location = new System.Drawing.Point(12, 86);
            this.labelCountOfIncorrectAnswer.Name = "labelCountOfIncorrectAnswer";
            this.labelCountOfIncorrectAnswer.Size = new System.Drawing.Size(46, 17);
            this.labelCountOfIncorrectAnswer.TabIndex = 1;
            this.labelCountOfIncorrectAnswer.Text = "label1";
            // 
            // labelCountOfCorrectAnswer
            // 
            this.labelCountOfCorrectAnswer.AutoSize = true;
            this.labelCountOfCorrectAnswer.Location = new System.Drawing.Point(12, 69);
            this.labelCountOfCorrectAnswer.Name = "labelCountOfCorrectAnswer";
            this.labelCountOfCorrectAnswer.Size = new System.Drawing.Size(46, 17);
            this.labelCountOfCorrectAnswer.TabIndex = 0;
            this.labelCountOfCorrectAnswer.Text = "label1";
            // 
            // listViewResult
            // 
            this.listViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.GridLines = true;
            this.listViewResult.Location = new System.Drawing.Point(0, 0);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(969, 578);
            this.listViewResult.TabIndex = 0;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(800, 13);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(166, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // DisplayResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 768);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayResultForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Display Result";
            this.Load += new System.EventHandler(this.DisplayResultForm_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerHeader.Panel1.ResumeLayout(false);
            this.splitContainerHeader.Panel1.PerformLayout();
            this.splitContainerHeader.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHeader)).EndInit();
            this.splitContainerHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.SplitContainer splitContainerHeader;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelExamCodeName;
        private System.Windows.Forms.Label labelExamDate;
        private System.Windows.Forms.Label labelCountOfIncorrectAnswer;
        private System.Windows.Forms.Label labelCountOfCorrectAnswer;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.ListView listViewResult;
    }
}