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
    public partial class ViewAgreements : Form
    {
        private ManageAgreements manageAgreements;
        int index;
        public ViewAgreements(int index, ManageAgreements manageAgreements)
        {
            InitializeComponent();
            this.manageAgreements = manageAgreements;
            this.index = index;

            Agreements[] array = manageAgreements.GetAllAgreements();
            for (int i = 0; i < array.Length; i++)
            {
                Agreements agreement = array[index];
                rtbAgreementContent.Text = agreement.GetAgreementText();
                tbParties.Text = $"{agreement.GetPartyA()} & {agreement.GetPartyB()}";
            }
        }

        private void ViewAgreements_Load(object sender, EventArgs e)
        {

        }

        private void ViewAgreements_Load_1(object sender, EventArgs e)
        {

        }
    }
}
