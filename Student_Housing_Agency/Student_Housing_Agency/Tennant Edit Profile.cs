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
    public partial class Tennant_Edit_Profile : Form
    {
        private User u = new User();
        public Tennant_Edit_Profile(int index, User user)
        {
            index = u.SelectedUser;
            this.u = user;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text) && string.IsNullOrEmpty(tbPassword.Text) && string.IsNullOrEmpty(tbPhoneNo.Text))
            {
                MessageBox.Show("Please fill in every field");
            }
            else
            {
                u.Username = tbUsername.Text;
                u.Password = tbPassword.Text;
                u.PhoneNumber = Convert.ToInt64(tbPhoneNo.Text);
                string newline = $"{u.Username},{u.Password},{u.FirstName},{u.LastName},{u.PhoneNumber},{u.RoomNumber}, {u.BirthDate}";
                u.EditInfo(newline, u.SelectedUser);
                UpdateNewInfo();
                MessageBox.Show("Updated Info.");
            }
        }
        private void RetrieveTenantInfo()
        {
            u.ReturnInfo();
            tbPhoneNo.Text = Convert.ToString(u.PhoneNumber);
            tbUsername.Text = u.Username;
            tbPassword.Text = u.Password;
        }

        private void Tennant_Edit_Profile_Load(object sender, EventArgs e)
        {
            RetrieveTenantInfo();

        }
        private void UpdateNewInfo()
        {
            Tennant.username.Clear();
            Tennant.password.Clear();
            Tennant.phonenumber.Clear();
            Tennant.username.AppendText(tbUsername.Text);
            Tennant.password.AppendText(tbPassword.Text);
            Tennant.phonenumber.AppendText(tbPhoneNo.Text);
        }
    }
}
