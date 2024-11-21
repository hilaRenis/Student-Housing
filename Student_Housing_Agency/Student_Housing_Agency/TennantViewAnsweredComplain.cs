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
    public partial class TennantViewAnsweredComplain : Form
    {
        ManageComplaints mc = new ManageComplaints();
        int index;
        public TennantViewAnsweredComplain(int index, ManageComplaints mc)
        {
            this.index = index;
            this.mc = mc;
            InitializeComponent();
            Complaints[] myArray = mc.GetComplaints();
            for (int i = 0; i < myArray.Length; i++)
            {
                Complaints complaints = myArray[index];
                tbTitle.Text = complaints.ComplaintTitle;
                rbtViewComplain.Text = complaints.ComplaintBody;
                rtbAnswerComplain.Text = complaints.AnswerComplaint;
            }
        }

        private void TennantViewAnsweredComplain_Load(object sender, EventArgs e)
        {

        }
    }
}
