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
    public partial class Edit_Tennant : Form
    {
        private User u = new User();
        public Edit_Tennant(int index, User user)
        {
            this.u = user;
            index = u.SelectedUser;
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUsername.Text) && string.IsNullOrEmpty(tbPassword.Text) && string.IsNullOrEmpty(tbEditName.Text) && string.IsNullOrEmpty(tbEditLastName.Text) && string.IsNullOrEmpty(tbEditPhoneNo.Text) && string.IsNullOrEmpty(tbRoomNo.Text) && string.IsNullOrEmpty(tbEditBirthDate.Text))
            {
                MessageBox.Show("Please enter all fields.");
            }
            else
            {
                u.FirstName = tbEditName.Text;
                u.LastName = tbEditLastName.Text;
                u.Username = tbUsername.Text;
                u.Password = tbPassword.Text;
                u.PhoneNumber = Convert.ToInt64(tbEditPhoneNo.Text);
                u.RoomNumber = Convert.ToInt32(tbRoomNo.Text);
                u.BirthDate = tbEditBirthDate.Text;
                string newline = $"{u.Username},{u.Password},{u.FirstName},{u.LastName},{u.PhoneNumber},{u.RoomNumber},{u.BirthDate}";
                u.EditInfo(newline, u.SelectedUser);
                MessageBox.Show("Updated tenant.");
                GetUserList();
            }
        }

        private void Edit_Tennant_Load(object sender, EventArgs e)
        {
            RetrieveTenantInfo();
        }
        private void RetrieveTenantInfo()
        {
            List<string> lines = File.ReadLines("user_info.txt").Take(u.SelectedUser).ToList();
            u.ReturnInfo();
            tbEditName.Text = u.FirstName;
            tbEditLastName.Text = u.LastName;
            tbEditPhoneNo.Text = Convert.ToString(u.PhoneNumber);
            tbRoomNo.Text = Convert.ToString(u.RoomNumber);
            tbUsername.Text = u.Username;
            tbPassword.Text = u.Password;
            tbEditBirthDate.Text = u.BirthDate;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetUserList()
        {
            Admin.tenantList.Items.Clear();
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

                Admin.tenantList.Items.Add($"{u.Username} - {u.FirstName} {u.LastName}");
            }
        }
    }
}
