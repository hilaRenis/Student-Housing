using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class Task
    {
        private string assignedPerson;
        private string taskTitle;
        private string taskDescription;
        private string taskDate;
        private bool isTaskDone;

        public Task(string assignedPerson, string taskTitle, string taskDescription, string taskDate)
        {
            this.assignedPerson = assignedPerson;
            this.taskTitle = taskTitle;
            this.taskDescription = taskDescription;
            this.taskDate = taskDate;
            this.isTaskDone = false;
        }

        public string GetAdminInfo()
        {
            string taskStatus;
            if (this.isTaskDone == true)
            {
                taskStatus = "complete";
            }
            else { taskStatus = "not complete"; }
            
            return $"{this.taskTitle}, {this.assignedPerson}, {this.taskDate} - {taskStatus}";
        }

        public string GetTenantInfo()
        {
            string taskStatus;
            if (this.isTaskDone == true)
            {
                taskStatus = "complete";
            }
            else { taskStatus = "not complete"; }

            return $"{this.taskTitle}, {this.taskDate} - {taskStatus}";
        }

        public string AssignedPerson
        {
            get { return this.assignedPerson; }
        }

        public string TaskDescription
        {
            get { return this.taskDescription; }
        }

        public bool IsTaskDone
        {
            get { return this.isTaskDone; }
            set { this.isTaskDone = value; }
        }
    }
}
