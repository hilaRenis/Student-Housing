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
    public partial class TennantMakeAnnouncment : Form
    {
        private User u = new User();
        Announcements announcements = new Announcements();
        public TennantMakeAnnouncment(Announcements ann, User user)
        {
            this.u = user;
            this.announcements = ann;
            InitializeComponent();
        }

        private void btnTennantCreateAnnouncment_Click(object sender, EventArgs e)
        {
            AddAnnouncement();
        }
        private void AddAnnouncement()
        {
            if (string.IsNullOrEmpty(tbTennantWriteTitle.Text) && string.IsNullOrEmpty(rbtWriteAnnouncment.Text))
            {
                MessageBox.Show("Please fill in everything!");
            }
            else
            {
                announcements.MakeAnnouncement(dtpExecutionDate.Value, tbTennantWriteTitle.Text, rbtWriteAnnouncment.Text, u.Username);
                Tennant.announcementList.Items.Clear();
                MessageBox.Show("Created a new announcement!");
                foreach (string announcemnt in announcements.AnnouncementList)
                {
                    Tennant.announcementList.Items.Add(announcemnt);
                }
                tbTennantWriteTitle.Clear();
                rbtWriteAnnouncment.Clear();
            }
        }
    }
}
