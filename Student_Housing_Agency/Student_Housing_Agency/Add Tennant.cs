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
    public partial class Add_Tennant : Form
    {
        User u = new User();
        public Add_Tennant()
        {
            InitializeComponent();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            u.Username = tbUsername.Text;
            u.Password = tbPassword.Text;
            u.FirstName = tbName.Text;
            u.LastName = tbLastName.Text;
            u.PhoneNumber = Convert.ToInt32(tbPhoneNo.Text);
            u.RoomNumber = Convert.ToInt32(tbRoomNo.Text);
            u.BirthDate = tbBirthDate.Text;
            if (String.IsNullOrEmpty(tbUsername.Text) && String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please input a Username and Password.");
            }
            else
            {
                u.AddInfo(tbUsername.Text, tbPassword.Text, tbName.Text, tbLastName.Text, Convert.ToInt64(tbPhoneNo.Text), Convert.ToInt32(tbRoomNo.Text), tbBirthDate.Text);
                UpdateTenants();
                MessageBox.Show("New user created.");
                tbUsername.Clear();
                tbPassword.Clear();
                tbName.Clear();
                tbLastName.Clear();
                tbPhoneNo.Clear();
                tbRoomNo.Clear();
                tbBirthDate.Clear();
            }
            
        }

        private void Add_Tennant_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbName;
        }
        private void UpdateTenants()
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
                u.PhoneNumber = Convert.ToInt32(fields[4]);
                u.RoomNumber = Convert.ToInt32(fields[5]);
                u.BirthDate = fields[6];

                Admin.tenantList.Items.Add($"{u.Username} - {u.FirstName} {u.LastName}");
            }
        }
    }
}
