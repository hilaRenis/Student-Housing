using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Housing_Agency
{
    public partial class LoginForm : Form
    {
        ManageRules ruleList = new ManageRules();
        private ManageBuildingLayout buildingLayout;
        private ManageShoppingList shoppingList;
        private ManageTasks manageTasks;
        User u = new User();
        private ManageAgreements manageAgreements = new ManageAgreements();
        private Announcements announcements = new Announcements();
        private ManageComplaints mc = new ManageComplaints();
        private string currentUser;

        public LoginForm()
        {
            InitializeComponent();
            buildingLayout = new ManageBuildingLayout();
            shoppingList = new ManageShoppingList();
            manageTasks = new ManageTasks();
        }

        public LoginForm(ManageRules ruleList, ManageBuildingLayout buildingLayout, ManageShoppingList shoppingList, User user, ManageAgreements manageAgreements, Announcements ann, ManageTasks manageTasks, ManageComplaints mc) //put the constructors here
        {
            InitializeComponent();
            this.ruleList = ruleList;
            this.buildingLayout = buildingLayout;
            this.shoppingList = shoppingList;
            this.manageTasks = manageTasks;
            this.u = user;
            this.manageAgreements = manageAgreements;
            this.announcements = ann;
            this.mc = mc;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbUsername.Text) || String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please enter username/password.");
            }
            else
            {
                u.Username = tbUsername.Text;
                u.Password = tbPassword.Text;
                List<string> lines = File.ReadAllLines("user_info.txt").ToList();
                if(u.UserLogin(u.Username, u.Password) == true)
                {
                    u.SetCurrentUser(tbUsername.Text);
                    if(u.Username.Contains("admin"))
                    {
                        this.Hide();
                        Admin admin = new Admin(ruleList, buildingLayout, shoppingList, u, manageAgreements, announcements, manageTasks, mc);
                        admin.Show();
                    }
                    else
                    {
                        u.MentionedUser = tbUsername.Text;
                        this.Hide();
                        Tennant tenant = new Tennant(ruleList, buildingLayout, shoppingList, u, manageAgreements, announcements, manageTasks, mc);
                        tenant.Show();
                    }
                }
                else
                {
                    MessageBox.Show("username and/or password doesn't match");
                }
            }

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }
        public string GetCurrentUser
        {
            get { return this.currentUser; }
            set { this.currentUser = tbUsername.Text; }
        }
    }
}
