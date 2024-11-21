using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class Complaints
    {
        private string complaintTitle;
        private string complaintBody;
        private string answer;
        private string tenant;
        private string admin;
        private string status;
        private bool isAnswered;
        public List<string> ListComplaints
        {
            get;
            set;
        }
        public bool IsAnswered
        {
            get { return this.isAnswered; }
            set { this.isAnswered = value; }
        }
        public string GetComplaint()
        {
            if(IsAnswered == true)
            {
                this.status = "Answered";
            }
            else
            {
                this.status = "Not Answered";
            }
            return ($"[{this.complaintTitle}] - {this.complaintBody} - ({this.status})");
        }
        public void SetComplaint(string title, string body, string status, string tenant)
        {
            this.complaintBody = body;
            this.complaintTitle = title;
            this.status = status;
            this.tenant = tenant;
        }


        public string ComplaintTitle
        {
            get { return this.complaintTitle; }
            set { this.complaintTitle = value; }
        }
        public string ComplaintBody
        {
            get { return this.complaintBody; }
            set { this.complaintBody = value; }
        }
    
        public string AnswerComplaint
        {
            get { return this.answer; }
            set { this.answer = value; }
        }
        public string Tenant
        {
            get { return this.tenant; }
            set { this.tenant = value; }
        }
        public string Admin
        {
            get { return this.admin; }
            set { this.admin = value; }
        }
    }
}
