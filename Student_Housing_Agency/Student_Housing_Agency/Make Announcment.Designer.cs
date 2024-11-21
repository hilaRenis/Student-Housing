
namespace Student_Housing_Agency
{
    partial class Make_Announcment
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
            this.lblExecutionDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.tbWriteTitle = new System.Windows.Forms.TextBox();
            this.rbtWriteAnnouncment = new System.Windows.Forms.RichTextBox();
            this.btnCreateAnnouncment = new System.Windows.Forms.Button();
            this.dtpExecutionDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblExecutionDate
            // 
            this.lblExecutionDate.AutoSize = true;
            this.lblExecutionDate.Location = new System.Drawing.Point(7, 32);
            this.lblExecutionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExecutionDate.Name = "lblExecutionDate";
            this.lblExecutionDate.Size = new System.Drawing.Size(83, 13);
            this.lblExecutionDate.TabIndex = 0;
            this.lblExecutionDate.Text = "Execution Date:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(7, 58);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(7, 84);
            this.lblContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(44, 13);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Content";
            // 
            // tbWriteTitle
            // 
            this.tbWriteTitle.Location = new System.Drawing.Point(128, 58);
            this.tbWriteTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbWriteTitle.Name = "tbWriteTitle";
            this.tbWriteTitle.Size = new System.Drawing.Size(174, 20);
            this.tbWriteTitle.TabIndex = 4;
            // 
            // rbtWriteAnnouncment
            // 
            this.rbtWriteAnnouncment.Location = new System.Drawing.Point(9, 100);
            this.rbtWriteAnnouncment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtWriteAnnouncment.Name = "rbtWriteAnnouncment";
            this.rbtWriteAnnouncment.Size = new System.Drawing.Size(313, 145);
            this.rbtWriteAnnouncment.TabIndex = 5;
            this.rbtWriteAnnouncment.Text = "";
            // 
            // btnCreateAnnouncment
            // 
            this.btnCreateAnnouncment.Location = new System.Drawing.Point(62, 249);
            this.btnCreateAnnouncment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateAnnouncment.Name = "btnCreateAnnouncment";
            this.btnCreateAnnouncment.Size = new System.Drawing.Size(196, 29);
            this.btnCreateAnnouncment.TabIndex = 6;
            this.btnCreateAnnouncment.Text = "Make the Announcment";
            this.btnCreateAnnouncment.UseVisualStyleBackColor = true;
            this.btnCreateAnnouncment.Click += new System.EventHandler(this.btnCreateAnnouncment_Click);
            // 
            // dtpExecutionDate
            // 
            this.dtpExecutionDate.Location = new System.Drawing.Point(128, 32);
            this.dtpExecutionDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpExecutionDate.Name = "dtpExecutionDate";
            this.dtpExecutionDate.Size = new System.Drawing.Size(174, 20);
            this.dtpExecutionDate.TabIndex = 7;
            // 
            // Make_Announcment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 288);
            this.Controls.Add(this.dtpExecutionDate);
            this.Controls.Add(this.btnCreateAnnouncment);
            this.Controls.Add(this.rbtWriteAnnouncment);
            this.Controls.Add(this.tbWriteTitle);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblExecutionDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Make_Announcment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Announcment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExecutionDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox tbWriteTitle;
        private System.Windows.Forms.RichTextBox rbtWriteAnnouncment;
        private System.Windows.Forms.Button btnCreateAnnouncment;
        private System.Windows.Forms.DateTimePicker dtpExecutionDate;
    }
}