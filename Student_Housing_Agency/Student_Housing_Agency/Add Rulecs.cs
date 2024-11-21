using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Housing_Agency
{
    public partial class Add_Rulecs : Form
    {
        private ManageRules ruleList = new ManageRules();

        public Add_Rulecs(ManageRules ruleList)
        {
            InitializeComponent();
            this.ruleList = ruleList;
        }

        private void btnAddNewRule_Click(object sender, EventArgs e)
        {
            AddRule();
        }

        private void AddRule()
        {
            if (rbtWriteNewRule.Text != "")
            {
                ruleList.AddRule(rbtWriteNewRule.Text);
                Admin.ruleListBox.Items.Clear();
                MessageBox.Show("Rule is succesfully added!");
                rbtWriteNewRule.Clear();
                foreach (string rule in ruleList.RuleList)
                {
                    Admin.ruleListBox.Items.Add(rule);
                }
            }
        }
    }
}
