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
    public partial class CreateAgreement : Form
    {
        ManageAgreements manageAgreements;
        User u;

        public CreateAgreement(ManageAgreements manageAgreements, User u)
        {
            InitializeComponent();
            this.manageAgreements = manageAgreements;
            this.u = u;
            GetUsers();
        }

        private void CreateAgreement_Load(object sender, EventArgs e)
        {
           
        }

        public void GetUsers()
        {
            List<string> lines = u.UserList;
            string CurrentUser = u.GetCurrentUser;
            lines.RemoveAt(0);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                u.FirstName = fields[2];
                u.LastName = fields[3];
                if (fields[0] != CurrentUser)
                {
                    cbTennant.Items.Add($"{u.FirstName} {u.LastName}");
                }
            }
        }

        private void UpdateTheAgreementsListBox()
        {
            Tennant.agreementListBox.Items.Clear();
            Agreements[] array = manageAgreements.GetAllAgreements();
            for (int i = 0; i < array.Length; i++)
            {
                Agreements agreement = array[i];
                if (agreement.GetPartyA() == AgreementUser() || agreement.GetPartyB() == AgreementUser())
                {
                    Tennant.agreementListBox.Items.Add($" ➤ ({manageAgreements.GetAllAgreements()[i].GetPartyA()} & {manageAgreements.GetAllAgreements()[i].GetPartyB()})--> {manageAgreements.GetAllAgreements()[i].GetAgreementText()}");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbTennant.SelectedItem == null)
            {
                MessageBox.Show("You have not choosen a tenant. Please choose a tenant to make an agreement!");
            }
            else
            {
                Agreements newAgreements = new Agreements();
                newAgreements.SetAgreementText(rtbWriteAgreement.Text);
                newAgreements.SetPartyA(AgreementUser());
                newAgreements.SetPartyB(cbTennant.SelectedItem.ToString());
                newAgreements.SetRemoveAgreement();
                manageAgreements.AddAgreement(newAgreements);
                MessageBox.Show("Agreement is succesfully added!");
                rtbWriteAgreement.Text = "";
                UpdateTheAgreementsListBox();
            }
        }
    }
}
