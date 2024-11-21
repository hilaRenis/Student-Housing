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
    public partial class Make_Announcment : Form
    {
        private User u = new User();
        Announcements announcements = new Announcements();
        public Make_Announcment(Announcements ann, User user)
        {
            InitializeComponent();
            this.u = user;
            this.announcements = ann;
        }

        private void btnCreateAnnouncment_Click(object sender, EventArgs e)
        {
            AddAnnouncement();
        }
        private void AddAnnouncement()
        {
            if (string.IsNullOrEmpty(tbWriteTitle.Text) && string.IsNullOrEmpty(rbtWriteAnnouncment.Text))
            {
                MessageBox.Show("Please fill in everything!");
            }
            else
            {
                u.Username = "Admin";
                announcements.MakeAnnouncement(dtpExecutionDate.Value, tbWriteTitle.Text, rbtWriteAnnouncment.Text, u.Username);
                Admin.announcementList.Items.Clear();
                MessageBox.Show("Created a new announcement!");
                foreach (string announcemnt in announcements.AnnouncementList)
                {
                    Admin.announcementList.Items.Add(announcemnt);
                }
                tbWriteTitle.Clear();
                rbtWriteAnnouncment.Clear();
            }
        }
    }
}
