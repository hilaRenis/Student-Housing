
namespace Student_Housing_Agency
{
    partial class ViewAgreements
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
            this.lblParties = new System.Windows.Forms.Label();
            this.tbParties = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.rtbAgreementContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblParties
            // 
            this.lblParties.AutoSize = true;
            this.lblParties.Location = new System.Drawing.Point(9, 69);
            this.lblParties.Name = "lblParties";
            this.lblParties.Size = new System.Drawing.Size(56, 17);
            this.lblParties.TabIndex = 0;
            this.lblParties.Text = "Parties:";
            // 
            // tbParties
            // 
            this.tbParties.Location = new System.Drawing.Point(71, 69);
            this.tbParties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbParties.Name = "tbParties";
            this.tbParties.ReadOnly = true;
            this.tbParties.Size = new System.Drawing.Size(297, 22);
            this.tbParties.TabIndex = 1;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(9, 129);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(57, 17);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Content";
            // 
            // rtbAgreementContent
            // 
            this.rtbAgreementContent.Location = new System.Drawing.Point(12, 162);
            this.rtbAgreementContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbAgreementContent.Name = "rtbAgreementContent";
            this.rtbAgreementContent.ReadOnly = true;
            this.rtbAgreementContent.Size = new System.Drawing.Size(356, 219);
            this.rtbAgreementContent.TabIndex = 3;
            this.rtbAgreementContent.Text = "";
            // 
            // ViewAgreements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 402);
            this.Controls.Add(this.rtbAgreementContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.tbParties);
            this.Controls.Add(this.lblParties);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewAgreements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAgreements";
            this.Load += new System.EventHandler(this.ViewAgreements_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParties;
        private System.Windows.Forms.TextBox tbParties;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.RichTextBox rtbAgreementContent;
    }
}