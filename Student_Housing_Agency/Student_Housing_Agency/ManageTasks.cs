using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class ManageTasks
    {
        private List<Task> taskList;

        public ManageTasks()
        {
            taskList = new List<Task>();
        }

        public void AddTask(string assignedPerson, string taskTitle, string taskDescription, string taskDate)
        {
            taskList.Add(new Task(assignedPerson, taskTitle, taskDescription, taskDate));
        }

        public void CompleteTask(int taskIndex, string currentUser)
        {
            int taskCounter = 0;
            foreach (Task t in this.taskList)
            {
                if (taskCounter == taskIndex)
                {
                    t.IsTaskDone = true;
                }
                taskCounter++;
            }
        }

        public void RemoveTask(int taskIndex)
        {
            taskList.RemoveAt(taskIndex);
        }

        public Task[] GetTasks()
        {
            return taskList.ToArray();
        }
    }
}
