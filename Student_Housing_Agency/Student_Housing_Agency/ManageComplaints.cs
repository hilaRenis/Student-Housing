using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class ManageComplaints
    {
        private List<Complaints> listComplaints = new List<Complaints>();
        public List<Complaints> ListCOmplaints()
        {
            return this.listComplaints;
        }

        public void AddComplaint(Complaints complaint)
        {
            this.listComplaints.Add(complaint);
        }
        public Complaints[] GetComplaints()
        {
            return this.listComplaints.ToArray();
        }
        public string ComplaintTenant
        {
            get;
            set;
        }
        public string ComplaintAdmin
        {
            get;
            set;
        }
    }
}
