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

    public partial class Tennant : Form
    {
        private User u = new User();
        private ManageRules ruleList = new ManageRules();
        private ManageBuildingLayout buildingLayout;
        private ManageShoppingList shoppingList;
        private ManageTasks manageTasks;
        private ManageAgreements manageAgreements =  new ManageAgreements();
        public static ListBox ruleListBox;
        public static ListBox agreementListBox;
        private Announcements announcements = new Announcements();
        public static ListBox announcementList;
        private ManageComplaints mc = new ManageComplaints();
        public static ListBox complaintList;
        public static TextBox username;
        public static TextBox password;
        public static TextBox phonenumber;


        public Tennant(ManageRules ruleList, ManageBuildingLayout buildingLayout, ManageShoppingList shoppingList, User user, ManageAgreements manageAgreements, Announcements ann, ManageTasks manageTasks, ManageComplaints mc)
        {
            InitializeComponent();
            this.ruleList = ruleList;
            this.buildingLayout = buildingLayout;
            this.shoppingList = shoppingList;
            this.manageTasks = manageTasks;
            this.u = user;
            this.manageAgreements = manageAgreements;
            ruleListBox = lbTennantViewRules;
            agreementListBox = lbAllAgreements;
            this.announcements = ann;
            this.mc = mc;
            complaintList = lbComplains;
            announcementList = lbTennantAnnouncment;
            username = tbViewUsername;
            password = tbViewPassword;
            phonenumber = tbViewPhoneNo;
            RefreshShoppingList();
            UpdateTasks();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lgn = new LoginForm(ruleList, buildingLayout, shoppingList, u, manageAgreements, announcements, manageTasks, mc);
            lgn.Show();
        }

        private void Tennant_Load(object sender, EventArgs e)
        {
            RefreshRule();
            LoadAllAgreements();
            ViewAnnouncements();
            RetrieveInfo();
            LoadComplaint();
        }

        private void RefreshRule()
        {
            foreach (string rule in ruleList.RuleList)
            {
                lbTennantViewRules.Items.Add(rule);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbItemName.Text))
            {
                MessageBox.Show("Please enter an item name");
            }
            else if (numItemCost.Value == 0)
            {
                MessageBox.Show("Please enter item cost");
            }
            else
            {
                string ItemName = tbItemName.Text;
                decimal ItemCost = numItemCost.Value;

                shoppingList.AddItem(ItemName, ItemCost);
            }
            RefreshShoppingList();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int ItemIndex = lbShoppingList.SelectedIndex;
            shoppingList.RemoveItem(ItemIndex);
            RefreshShoppingList();
        }

        private void RefreshShoppingList()
        {
            lbShoppingList.Items.Clear();
            List<ShoppingItem> ItemList = new List<ShoppingItem>();
            ItemList = shoppingList.ItemList;

            foreach (ShoppingItem item in ItemList)
            {
                string Info = item.GetInfo();
                lbShoppingList.Items.Add(Info);
            }
        }

        private void btnCreateAgreement_Click(object sender, EventArgs e)
        {
            CreateAgreement newTenantCreateAgreementPage = new CreateAgreement(manageAgreements, u);
            newTenantCreateAgreementPage.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Button for tenant to remove agreements
        {
            if (lbAllAgreements.SelectedItem == null)
            {
                MessageBox.Show("You have not select an agreement to remove. Please select one!");
                return;
            }
            manageAgreements.RemoveSelectedAgreement(lbAllAgreements.SelectedItem.ToString());
            MessageBox.Show("Agreement succesfully removed ! ");
            agreementListBox.Items.Clear();
            Agreements[] array = manageAgreements.GetAllAgreements();
            for (int i = 0; i < array.Length; i++)
            {
                Agreements agreement = array[i];
                if (agreement.GetPartyA() == AgreementUser() || agreement.GetPartyB() == AgreementUser())
                {
                    lbAllAgreements.Items.Add($" ➤ ({manageAgreements.GetAllAgreements()[i].GetPartyA()} & {manageAgreements.GetAllAgreements()[i].GetPartyB()})--> {manageAgreements.GetAllAgreements()[i].GetAgreementText()}");
                }
            }
        }

        private void LoadAllAgreements()
        {
            Agreements[] array = manageAgreements.GetAllAgreements();
            for (int i = 0; i < array.Length; i++)
            {
                Agreements agreement = array[i];
                if (agreement.GetPartyA() == AgreementUser() || agreement.GetPartyB() == AgreementUser())
                {
                    lbAllAgreements.Items.Add($" ➤ ({manageAgreements.GetAllAgreements()[i].GetPartyA()} & {manageAgreements.GetAllAgreements()[i].GetPartyB()})--> {manageAgreements.GetAllAgreements()[i].GetAgreementText()}");
                }
            }
        }
        private void LoadComplaint()
        {
            Complaints[] complaints = mc.GetComplaints();
            foreach (Complaints c in complaints)
            {
                if(c.Tenant == u.MentionedUser && u.MentionedUser == u.GetCurrentUser)
                {
                    lbComplains.Items.Add(c.GetComplaint());
                }
                
            } 
        }


        private string AgreementUser()
        {
            u.ReturnInfo();
            string x = u.GetCurrentUser;
            x = $"{u.FirstName} {u.LastName}";
            return x;
        }

        private void btnTennantMakeAnnouncment_Click(object sender, EventArgs e)
        {
            TennantMakeAnnouncment tma = new TennantMakeAnnouncment(announcements, u);
            tma.Show();
        }
        private void ViewAnnouncements()
        {
            foreach (string ann in announcements.AnnouncementList)
            {
                lbTennantAnnouncment.Items.Add(ann);
            }
        }

        private void RetrieveInfo()
        {
            u.ReturnInfo();
            this.Text = u.GetCurrentUser;
            this.Text = $"Tenant: {u.FirstName} {u.LastName}";
            tbViewName.Text = u.FirstName;
            tbViewLastName.Text = u.LastName;
            tbViewPhoneNo.Text = Convert.ToString(u.PhoneNumber);
            tbViewRoomNo.Text = Convert.ToString(u.RoomNumber);
            tbViewUsername.Text = u.Username;
            tbViewPassword.Text = u.Password;
            tbViewBirthDate.Text = u.BirthDate;
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            int taskIndex = lbViewTasks.SelectedIndex;
            manageTasks.CompleteTask(taskIndex, u.GetCurrentUser);
            UpdateTasks();
        }

        private void UpdateTasks()
        {
            lbViewTasks.Items.Clear();
            Task[] taskList = manageTasks.GetTasks();
            foreach(Task t in taskList)
            {
                if (t.AssignedPerson == u.GetCurrentUser)
                {
                    lbViewTasks.Items.Add(t.GetTenantInfo());
                }
            }
        }

        private void btnMakeComplain_Click(object sender, EventArgs e)
        {
            TennantMakeComplain tmc = new TennantMakeComplain(u, mc);
            tmc.Show();
        }

        private void btnEditTennantProfile_Click(object sender, EventArgs e)
        {
            u.SetCurrentUser(u.GetCurrentUser);
            u.SelectedUser = GetLineNumber();
            Tennant_Edit_Profile tep = new Tennant_Edit_Profile(u.SelectedUser ,u);
            tep.Show();
        }
        private int GetLineNumber()
        {
            u.ReturnInfo();
            int lineNum = 0;
            foreach (string line in u.UserList)
            {
                lineNum++;
                if (line.Contains(u.Username))
                {
                    return lineNum - 1;
                }
            }
            return lineNum;
        }

        private void btnViewTheSelectedComplain_Click(object sender, EventArgs e)
        {
            if (lbComplains.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a complaint first.");
            }
            else
            {
                int compIndex = lbComplains.SelectedIndex;
                TennantViewAnsweredComplain tvac = new TennantViewAnsweredComplain(compIndex, mc);
                tvac.Show();
            }
        }
    }
}
