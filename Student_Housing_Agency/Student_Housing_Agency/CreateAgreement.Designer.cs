
namespace Student_Housing_Agency
{
    partial class CreateAgreement
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
            this.lblTennant = new System.Windows.Forms.Label();
            this.cbTennant = new System.Windows.Forms.ComboBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtbWriteAgreement = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTennant
            // 
            this.lblTennant.AutoSize = true;
            this.lblTennant.Location = new System.Drawing.Point(25, 46);
            this.lblTennant.Name = "lblTennant";
            this.lblTennant.Size = new System.Drawing.Size(65, 17);
            this.lblTennant.TabIndex = 0;
            this.lblTennant.Text = "Tennant:";
            // 
            // cbTennant
            // 
            this.cbTennant.FormattingEnabled = true;
            this.cbTennant.Location = new System.Drawing.Point(124, 46);
            this.cbTennant.Name = "cbTennant";
            this.cbTennant.Size = new System.Drawing.Size(168, 24);
            this.cbTennant.TabIndex = 1;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(25, 100);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(57, 17);
            this.lblContent.TabIndex = 2;
            this.lblContent.Text = "Content";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtbWriteAgreement
            // 
            this.rtbWriteAgreement.Location = new System.Drawing.Point(28, 120);
            this.rtbWriteAgreement.Name = "rtbWriteAgreement";
            this.rtbWriteAgreement.Size = new System.Drawing.Size(264, 208);
            this.rtbWriteAgreement.TabIndex = 5;
            this.rtbWriteAgreement.Text = "";
            // 
            // CreateAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 393);
            this.Controls.Add(this.rtbWriteAgreement);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.cbTennant);
            this.Controls.Add(this.lblTennant);
            this.Name = "CreateAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Agreement";
            this.Load += new System.EventHandler(this.CreateAgreement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTennant;
        private System.Windows.Forms.ComboBox cbTennant;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtbWriteAgreement;
    }
}