
namespace Student_Housing_Agency
{
    partial class Add_Rulecs
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
            this.lblTypeNewRule = new System.Windows.Forms.Label();
            this.rbtWriteNewRule = new System.Windows.Forms.RichTextBox();
            this.btnAddNewRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeNewRule
            // 
            this.lblTypeNewRule.AutoSize = true;
            this.lblTypeNewRule.Location = new System.Drawing.Point(125, 20);
            this.lblTypeNewRule.Name = "lblTypeNewRule";
            this.lblTypeNewRule.Size = new System.Drawing.Size(104, 17);
            this.lblTypeNewRule.TabIndex = 1;
            this.lblTypeNewRule.Text = "Type New Rule";
            // 
            // rbtWriteNewRule
            // 
            this.rbtWriteNewRule.Location = new System.Drawing.Point(12, 53);
            this.rbtWriteNewRule.Name = "rbtWriteNewRule";
            this.rbtWriteNewRule.Size = new System.Drawing.Size(364, 134);
            this.rbtWriteNewRule.TabIndex = 2;
            this.rbtWriteNewRule.Text = "";
            // 
            // btnAddNewRule
            // 
            this.btnAddNewRule.Location = new System.Drawing.Point(128, 207);
            this.btnAddNewRule.Name = "btnAddNewRule";
            this.btnAddNewRule.Size = new System.Drawing.Size(101, 43);
            this.btnAddNewRule.TabIndex = 3;
            this.btnAddNewRule.Text = "Add";
            this.btnAddNewRule.UseVisualStyleBackColor = true;
            this.btnAddNewRule.Click += new System.EventHandler(this.btnAddNewRule_Click);
            // 
            // Add_Rulecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 266);
            this.Controls.Add(this.btnAddNewRule);
            this.Controls.Add(this.rbtWriteNewRule);
            this.Controls.Add(this.lblTypeNewRule);
            this.Name = "Add_Rulecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Rule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTypeNewRule;
        private System.Windows.Forms.RichTextBox rbtWriteNewRule;
        private System.Windows.Forms.Button btnAddNewRule;
    }
}