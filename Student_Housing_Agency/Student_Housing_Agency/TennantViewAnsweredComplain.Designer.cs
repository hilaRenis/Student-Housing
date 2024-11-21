
namespace Student_Housing_Agency
{
    partial class TennantViewAnsweredComplain
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
            this.rtbAnswerComplain = new System.Windows.Forms.RichTextBox();
            this.lblAnswerComplain = new System.Windows.Forms.Label();
            this.rbtViewComplain = new System.Windows.Forms.RichTextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbAnswerComplain
            // 
            this.rtbAnswerComplain.Location = new System.Drawing.Point(19, 274);
            this.rtbAnswerComplain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbAnswerComplain.Name = "rtbAnswerComplain";
            this.rtbAnswerComplain.ReadOnly = true;
            this.rtbAnswerComplain.Size = new System.Drawing.Size(471, 134);
            this.rtbAnswerComplain.TabIndex = 11;
            this.rtbAnswerComplain.Text = "";
            // 
            // lblAnswerComplain
            // 
            this.lblAnswerComplain.AutoSize = true;
            this.lblAnswerComplain.Location = new System.Drawing.Point(16, 254);
            this.lblAnswerComplain.Name = "lblAnswerComplain";
            this.lblAnswerComplain.Size = new System.Drawing.Size(199, 17);
            this.lblAnswerComplain.TabIndex = 10;
            this.lblAnswerComplain.Text = "The Answer of Your Complain:";
            // 
            // rbtViewComplain
            // 
            this.rbtViewComplain.Location = new System.Drawing.Point(19, 90);
            this.rbtViewComplain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtViewComplain.Name = "rbtViewComplain";
            this.rbtViewComplain.Size = new System.Drawing.Size(471, 134);
            this.rbtViewComplain.TabIndex = 9;
            this.rbtViewComplain.Text = "";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(19, 70);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(57, 17);
            this.lblContent.TabIndex = 8;
            this.lblContent.Text = "Content";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(91, 39);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(159, 22);
            this.tbTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title:";
            // 
            // TennantViewAnsweredComplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 449);
            this.Controls.Add(this.rtbAnswerComplain);
            this.Controls.Add(this.lblAnswerComplain);
            this.Controls.Add(this.rbtViewComplain);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TennantViewAnsweredComplain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tennant View Answered Complain";
            this.Load += new System.EventHandler(this.TennantViewAnsweredComplain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAnswerComplain;
        private System.Windows.Forms.Label lblAnswerComplain;
        private System.Windows.Forms.RichTextBox rbtViewComplain;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}