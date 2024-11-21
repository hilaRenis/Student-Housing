using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class Announcements
    {
        private List<string> announcementList;

        public Announcements()
        {
            announcementList = new List<string>();
        }
        public void MakeAnnouncement(DateTime execDate, string title, string content, string username)
        {
            announcementList.Add($"({execDate}) [{title}]: {content} - {username}");
        }
        public List<string> AnnouncementList
        {
            get
            {
                return announcementList;
            }
            set
            {
                announcementList = value;
            }

        }
    }
}
