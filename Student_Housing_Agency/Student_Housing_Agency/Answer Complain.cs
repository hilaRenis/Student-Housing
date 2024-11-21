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
    public partial class Answer_Complain : Form
    {
        private ManageComplaints mc = new ManageComplaints();
        User u = new User();
        private int index;
        public Answer_Complain(int index, ManageComplaints mc, User user)
        {
            this.index = index;
            this.mc = mc;
            this.u = user;
            InitializeComponent();
            Complaints[] myArray = mc.GetComplaints();
            for(int i = 0; i < myArray.Length; i++)
            {
                Complaints complaints = myArray[index];
                tbTitle.Text = complaints.ComplaintTitle;
                rbtViewComplain.Text = complaints.ComplaintBody;
                u.MentionedUser = complaints.Tenant;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbAnswerComplain.Text))
            {
                MessageBox.Show("Please enter your reply.");
            }
            else
            {

                Complaints comp = new Complaints();
                comp.ComplaintTitle = tbTitle.Text;
                comp.ComplaintBody = rbtViewComplain.Text;
                comp.AnswerComplaint = rtbAnswerComplain.Text;
                comp.IsAnswered = true;
                comp.Tenant = u.MentionedUser;
                comp.Admin = mc.ComplaintAdmin;
                comp.SetComplaint(comp.ComplaintTitle, comp.ComplaintBody, comp.AnswerComplaint, u.MentionedUser);
                Admin.complaintList.Items.Clear();
                mc.ListCOmplaints().RemoveAt(index);
                mc.AddComplaint(comp);
                UpdateComplaintList();
                MessageBox.Show("Complaint has been answered");
                rtbAnswerComplain.Clear();
            }
        }
        private void UpdateComplaintList()
        {
            Admin.complaintList.Items.Clear();
            Complaints[] compList = mc.GetComplaints();
            foreach (Complaints c in compList)
            {
                 Admin.complaintList.Items.Add(c.GetComplaint());
            }
        }
        private void Answer_Complain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = rtbAnswerComplain;
        }
    }
}
