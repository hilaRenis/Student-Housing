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
    public partial class TennantMakeComplain : Form
    {
        User u = new User();
        ManageComplaints mc;
        public TennantMakeComplain(User user, ManageComplaints manageComplaints)
        {
            this.u = user;
            this.mc = manageComplaints;
            InitializeComponent();
            u.ReturnInfo();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitle.Text) || string.IsNullOrEmpty(rtbWriteComplain.Text))
            {
                MessageBox.Show("Please enter the title and body of your complaint.");
            }
            else
            {
                Complaints complaints = new Complaints();
                string x = "";
                complaints.ComplaintTitle = tbTitle.Text;
                complaints.ComplaintBody = rtbWriteComplain.Text;
                complaints.AnswerComplaint = x;
                complaints.Tenant = u.GetCurrentUser;
                complaints.IsAnswered = false;
                complaints.SetComplaint(complaints.ComplaintTitle, complaints.ComplaintBody, x, u.MentionedUser);
                mc.AddComplaint(complaints);
                UpdateComplaintList();
                MessageBox.Show("Complaint sent to admin");

                tbTitle.Clear();
                rtbWriteComplain.Clear();
                this.Close();
            }
        }

        private void UpdateComplaintList()
        {
            Tennant.complaintList.Items.Clear();
            Complaints[] compList = mc.GetComplaints();
            foreach(Complaints c in compList)
            {
                if(c.Tenant == u.GetCurrentUser)
                {
                    Tennant.complaintList.Items.Add(c.GetComplaint());
                }
            }
        }
        private void IsMentioned()
        {
            u.ReturnInfo();
            u.MentionedUser = u.GetCurrentUser;
        }
        private void TennantMakeComplain_Load(object sender, EventArgs e)
        {
            IsMentioned();
        }
    }
}
