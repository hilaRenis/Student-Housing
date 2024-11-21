
namespace Student_Housing_Agency
{
    partial class TennantMakeAnnouncment
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
            this.dtpExecutionDate = new System.Windows.Forms.DateTimePicker();
            this.btnTennantCreateAnnouncment = new System.Windows.Forms.Button();
            this.rbtWriteAnnouncment = new System.Windows.Forms.RichTextBox();
            this.tbTennantWriteTitle = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblExecutionDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpExecutionDate
            // 
            this.dtpExecutionDate.Location = new System.Drawing.Point(133, 20);
            this.dtpExecutionDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpExecutionDate.Name = "dtpExecutionDate";
            this.dtpExecutionDate.Size = new System.Drawing.Size(174, 20);
            this.dtpExecutionDate.TabIndex = 14;
            // 
            // btnTennantCreateAnnouncment
            // 
            this.btnTennantCreateAnnouncment.Location = new System.Drawing.Point(66, 238);
            this.btnTennantCreateAnnouncment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTennantCreateAnnouncment.Name = "btnTennantCreateAnnouncment";
            this.btnTennantCreateAnnouncment.Size = new System.Drawing.Size(196, 29);
            this.btnTennantCreateAnnouncment.TabIndex = 13;
            this.btnTennantCreateAnnouncment.Text = "Make the Announcment";
            this.btnTennantCreateAnnouncment.UseVisualStyleBackColor = true;
            this.btnTennantCreateAnnouncment.Click += new System.EventHandler(this.btnTennantCreateAnnouncment_Click);
            // 
            // rbtWriteAnnouncment
            // 
            this.rbtWriteAnnouncment.Location = new System.Drawing.Point(14, 89);
            this.rbtWriteAnnouncment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtWriteAnnouncment.Name = "rbtWriteAnnouncment";
            this.rbtWriteAnnouncment.Size = new System.Drawing.Size(313, 145);
            this.rbtWriteAnnouncment.TabIndex = 12;
            this.rbtWriteAnnouncment.Text = "";
            // 
            // tbTennantWriteTitle
            // 
            this.tbTennantWriteTitle.Location = new System.Drawing.Point(133, 46);
            this.tbTennantWriteTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTennantWriteTitle.Name = "tbTennantWriteTitle";
            this.tbTennantWriteTitle.Size = new System.Drawing.Size(174, 20);
            this.tbTennantWriteTitle.TabIndex = 11;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(11, 72);
            this.lblContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(44, 13);
            this.lblContent.TabIndex = 10;
            this.lblContent.Text = "Content";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(11, 46);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title:";
            // 
            // lblExecutionDate
            // 
            this.lblExecutionDate.AutoSize = true;
            this.lblExecutionDate.Location = new System.Drawing.Point(11, 20);
            this.lblExecutionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExecutionDate.Name = "lblExecutionDate";
            this.lblExecutionDate.Size = new System.Drawing.Size(83, 13);
            this.lblExecutionDate.TabIndex = 8;
            this.lblExecutionDate.Text = "Execution Date:";
            // 
            // TennantMakeAnnouncment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 288);
            this.Controls.Add(this.dtpExecutionDate);
            this.Controls.Add(this.btnTennantCreateAnnouncment);
            this.Controls.Add(this.rbtWriteAnnouncment);
            this.Controls.Add(this.tbTennantWriteTitle);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblExecutionDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TennantMakeAnnouncment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tennant Make Announcment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpExecutionDate;
        private System.Windows.Forms.Button btnTennantCreateAnnouncment;
        private System.Windows.Forms.RichTextBox rbtWriteAnnouncment;
        private System.Windows.Forms.TextBox tbTennantWriteTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblExecutionDate;
    }
}