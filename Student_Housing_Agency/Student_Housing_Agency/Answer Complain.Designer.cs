
namespace Student_Housing_Agency
{
    partial class Answer_Complain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.rbtViewComplain = new System.Windows.Forms.RichTextBox();
            this.lblAnswerComplain = new System.Windows.Forms.Label();
            this.rtbAnswerComplain = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(7, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(62, 12);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(120, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(9, 37);
            this.lblContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(44, 13);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Content";
            // 
            // rbtViewComplain
            // 
            this.rbtViewComplain.Location = new System.Drawing.Point(9, 53);
            this.rbtViewComplain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtViewComplain.Name = "rbtViewComplain";
            this.rbtViewComplain.ReadOnly = true;
            this.rbtViewComplain.Size = new System.Drawing.Size(354, 110);
            this.rbtViewComplain.TabIndex = 3;
            this.rbtViewComplain.Text = "";
            // 
            // lblAnswerComplain
            // 
            this.lblAnswerComplain.AutoSize = true;
            this.lblAnswerComplain.Location = new System.Drawing.Point(7, 186);
            this.lblAnswerComplain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswerComplain.Name = "lblAnswerComplain";
            this.lblAnswerComplain.Size = new System.Drawing.Size(109, 13);
            this.lblAnswerComplain.TabIndex = 4;
            this.lblAnswerComplain.Text = "Answer the Complaint";
            // 
            // rtbAnswerComplain
            // 
            this.rtbAnswerComplain.Location = new System.Drawing.Point(9, 202);
            this.rtbAnswerComplain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbAnswerComplain.Name = "rtbAnswerComplain";
            this.rtbAnswerComplain.Size = new System.Drawing.Size(354, 110);
            this.rtbAnswerComplain.TabIndex = 5;
            this.rtbAnswerComplain.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(159, 328);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 27);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Answer_Complain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 365);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtbAnswerComplain);
            this.Controls.Add(this.lblAnswerComplain);
            this.Controls.Add(this.rbtViewComplain);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Answer_Complain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Answer Complain";
            this.Load += new System.EventHandler(this.Answer_Complain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.RichTextBox rbtViewComplain;
        private System.Windows.Forms.Label lblAnswerComplain;
        private System.Windows.Forms.RichTextBox rtbAnswerComplain;
        private System.Windows.Forms.Button btnSend;
    }
}