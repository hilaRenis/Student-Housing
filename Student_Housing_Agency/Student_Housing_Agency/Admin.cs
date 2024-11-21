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
    public partial class Admin : Form
    {
        private User u = new User();
        private ManageRules ruleList = new ManageRules();
        private ManageBuildingLayout buildingLayout;
        private ManageShoppingList shoppingList;
        private ManageTasks manageTasks;
        private ManageAgreements manageAgreements = new ManageAgreements();
        Add_Rulecs addNewRuleForm;
        public static ListBox Userlist;
        public static ListBox ruleListBox;
        private Announcements announcements = new Announcements();
        public static ListBox announcementList;
        private ManageComplaints mc = new ManageComplaints();
        public static ListBox complaintList;
        public static ListBox tenantList;


        public Admin(ManageRules ruleList, ManageBuildingLayout buildingLayout, ManageShoppingList shoppingList, User user, ManageAgreements manageAgreements, Announcements ann, ManageTasks manageTasks, ManageComplaints mc)
        {
            InitializeComponent();
            this.ruleList = ruleList;
            this.buildingLayout = buildingLayout;
            this.shoppingList = shoppingList;
            this.manageTasks = manageTasks;
            this.u = user;
            this.manageAgreements = manageAgreements;
            this.announcements = ann;
            announcementList = lbAnnouncment;
            this.mc = mc;
            tenantList = lblTennantInfo;
            complaintList = lbComplains;

            ruleListBox = lbRules;
            RefreshBuildingLayout();
            UpdateTasks();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lgn = new LoginForm(ruleList, buildingLayout, shoppingList, u, manageAgreements, announcements, manageTasks, mc);
            lgn.Show();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            addNewRuleForm = new Add_Rulecs(ruleList);
            addNewRuleForm.Show();
        }

        private void btnRemoveRule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(lbRules.SelectedIndex)) == false)
            {
                RemoveSelectedRule();
            }
            else
            {
                MessageBox.Show("You have not select a rule!");
            }
        }

        private void RemoveSelectedRule()
        {
            ruleList.RemoveRule(lbRules.SelectedIndex);
            lbRules.Items.Clear();
            foreach (string rule in ruleList.RuleList)
            {
                lbRules.Items.Add(rule);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            ShiftRuleUp();
        }

        private void ShiftRuleUp()
        {
            int i = ruleListBox.SelectedIndex;
            if (i > 0)
            {
                string item = ruleListBox.SelectedItem.ToString();
                ruleListBox.Items.RemoveAt(i);
                ruleListBox.Items.Insert(i - 1, item);
                ruleListBox.SetSelected(i - 1, true);
                ruleList.ShiftRuleUp(i);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            ShiftRuleDown();
        }

        private void ShiftRuleDown()
        {
            int i = ruleListBox.SelectedIndex;
            if (i < ruleListBox.Items.Count - 1)
            {
                string item = ruleListBox.SelectedItem.ToString();
                ruleListBox.Items.RemoveAt(i);
                ruleListBox.Items.Insert(i + 1, item);
                ruleListBox.SetSelected(i + 1, true);
                ruleList.ShiftRuleDown(i);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            RefreshRules();
            GetUserList();
            LoadAgreements();
            ViewAnnouncements();
            RetrieveInfo();
            LoadComplaint();
        }

        private void RefreshRules()
        {
            foreach (string rule in ruleList.RuleList)
            {
                lbRules.Items.Add(rule);
            }
        }

        //BUILDING LAYOUT

        private void btnAddBuilduingLayout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRoom.Text))
            {
                MessageBox.Show("Please input a room name");
            }
            else
            {
                string RoomName = tbRoom.Text;

                RoomTypes RoomType;
                if (rbBathroom.Checked == true)
                {
                    RoomType = RoomTypes.Bathroom;
                    buildingLayout.AddRoom(RoomName, RoomType);
                }
                else if (rbKitchen.Checked == true)
                {
                    RoomType = RoomTypes.Kitchen;
                    buildingLayout.AddRoom(RoomName, RoomType);
                }
                else if (rbStudentRoom.Checked == true)
                {
                    RoomType = RoomTypes.StudentRoom;
                    buildingLayout.AddRoom(RoomName, RoomType);
                }
                else if (rbOther.Checked == true)
                {
                    RoomType = RoomTypes.Other;
                    buildingLayout.AddRoom(RoomName, RoomType);
                }
                else
                {
                    MessageBox.Show("Please select atleast one of the roomtypes.");
                }
                RefreshBuildingLayout();
            }

        }

        private void btnRemoveBuilduingLayout_Click(object sender, EventArgs e)
        {
            int RoomIndex = lbBuilduingLayout.SelectedIndex;
            buildingLayout.RemoveRoom(RoomIndex);
            RefreshBuildingLayout();
        }

        private void RefreshBuildingLayout()
        {
            lbBuilduingLayout.Items.Clear();
            List<Room> roomlist = new List<Room>();
            roomlist = buildingLayout.RoomList;

            foreach (Room room in roomlist)
            {
                string Info = room.Getinfo();
                lbBuilduingLayout.Items.Add(Info);
            }
        }

        private void btnAddTennant_Click_1(object sender, EventArgs e)
        {
            Add_Tennant add_tenant = new Add_Tennant();
            add_tenant.Show();
        }

        private void GetUserList()
        {
            List<string> lines = u.UserList;
            lines.RemoveAt(0);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                u.Username = fields[0];
                u.Password = fields[1];
                u.FirstName = fields[2];
                u.LastName = fields[3];
                u.PhoneNumber = Convert.ToInt64(fields[4]);
                u.RoomNumber = Convert.ToInt32(fields[5]);
                u.BirthDate = fields[6];

                lblTennantInfo.Items.Add($"{u.Username} - {u.FirstName} {u.LastName}");
            }
        }

        private void LoadAgreements()
        {
            Agreements[] array = manageAgreements.GetAllAgreements();
            for (int i = 0; i < array.Length; i++)
            {
                Agreements agreement = array[i];
                lbAgreements.Items.Add($" ➤ {agreement.GetAgreementText()}");
            }
        }
        private void btnViewAgreement_Click(object sender, EventArgs e)
        {
            ViewAgreements newViewAgreementsPage = new ViewAgreements(lbAgreements.SelectedIndex, manageAgreements);
            newViewAgreementsPage.Show();
        }

        private void btnMakeAnnouncment_Click(object sender, EventArgs e)
        {
            Make_Announcment ma = new Make_Announcment(announcements, u);
            ma.Show();
        }
        private void ViewAnnouncements()
        {
            foreach (string ann in announcements.AnnouncementList)
            {
                lbAnnouncment.Items.Add(ann);
            }
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value != null && string.IsNullOrEmpty(tbTaskTitle.Text) == false && string.IsNullOrEmpty(tbDescription.Text) == false && cbxTaskAssignedPerson.SelectedIndex > 0)
            {
                string assignedPerson = cbxTaskAssignedPerson.Text;
                string taskTitle = tbTaskTitle.Text;
                string taskDescription = tbDescription.Text;
                string taskDate = dtpStartDate.Value.ToShortDateString();
                manageTasks.AddTask(assignedPerson, taskTitle, taskDescription, taskDate);
                UpdateTasks();
                cbxTaskAssignedPerson.SelectedIndex = 0;
            }
            else { MessageBox.Show("Please fill in all the information"); }
        }
        
        private void LoadComplaint()
        {
            lbComplains.Items.Clear();
            Complaints[] complaints = mc.GetComplaints();
            foreach(Complaints c in complaints)
            {
                lbComplains.Items.Add(c.GetComplaint());
            } 
        }
        
        private void UpdateTasks()
        {
            lbViewTask.Items.Clear();
            Task[] taskList = manageTasks.GetTasks();
            foreach (Task t in taskList)
            {
                lbViewTask.Items.Add(t.GetAdminInfo());
            }

            cbxTaskAssignedPerson.Items.Clear();
            cbxTaskAssignedPerson.Items.Add("");
            List<string> userList = u.UserList;
            int UserIndex = 0;
            foreach (string u in userList)
            {
                if (UserIndex > 0)
                {
                    string[] fields = u.Split(',');
                    cbxTaskAssignedPerson.Items.Add($"{fields[0]}");
                }
                UserIndex++;
            }
        }

        private void btnClearCompletedTasks_Click(object sender, EventArgs e)
        {
            Task[] taskList = manageTasks.GetTasks();
            int taskIndex = 0;
            foreach (Task t in taskList)
            {
                if (t.IsTaskDone == true)
                {
                    manageTasks.RemoveTask(taskIndex);
                }
                taskIndex++;
            }
            UpdateTasks();
        }
        private void RetrieveInfo()
        {
            u.ReturnInfo();
            u.SetCurrentUser(u.Username);
            this.Text = u.GetCurrentUser;
        }

        private void btnViewTheSelectedComplain_Click(object sender, EventArgs e)
        {
            if(lbComplains.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a complaint first.");
            }
            else
            {

                int compIndex = lbComplains.SelectedIndex;
                Answer_Complain answer = new Answer_Complain(compIndex, mc, u);
                answer.Show();
            }
        }

        private void btnRemoveTennant_Click(object sender, EventArgs e)
        {
            if (lblTennantInfo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a tenant.");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure?", "Deleting tenant", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    string x = Convert.ToString(lblTennantInfo.SelectedItem);
                    string[] y = x.Split('-');
                    string word = y[0];
                    int z = lblTennantInfo.SelectedIndex + 1;
                    List<string> lines = File.ReadAllLines("user_info.txt").ToList();
                    lines.RemoveAt(z);
                    File.WriteAllLines("user_info.txt", lines.ToArray());
                    lblTennantInfo.Items.RemoveAt(lblTennantInfo.SelectedIndex);
                }
            }
        }

        private void cbxTaskAssignedPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditTennant_Click(object sender, EventArgs e)
        {
            if (lblTennantInfo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a tenant.");
            }
            else
            {
                u.SelectedUser = lblTennantInfo.SelectedIndex + 1;
                string path = File.ReadLines("user_info.txt").ElementAt(u.SelectedUser);
                string[] fields = path.Split(',');
                u.SetCurrentUser(fields[0]);
                Edit_Tennant edit = new Edit_Tennant(u.SelectedUser, u);
                edit.Show();
            }
        }
    }
}
