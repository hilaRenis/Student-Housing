using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Student_Housing_Agency
{
    public class User
    {
        private string username;
        private string password;
        private string firstname;
        private string lastname;
        private long phone;
        private int room;
        private string birthdate;
        private string currentUSer;
        private int selectedUser;
        private List<string> userList;

        public List<string> UserList
        {
            get
            {
                this.userList = File.ReadAllLines("user_info.txt").ToList();
                return this.userList;
            }
        }
        public void SetCurrentUser(string currentuser)
        {
            this.currentUSer = currentuser;
        }
        public string GetCurrentUser
        {
            get { return this.currentUSer; }
        }
        public int SelectedUser
        {
            get { return this.selectedUser; }
            set { this.selectedUser = value; }
        }
        public string MentionedUser
        {
            get;
            set;
        }
        public void ReturnInfo()
        {
            foreach(string line in UserList.Where(StringToCheck => StringToCheck.Contains(this.currentUSer)))
            {
                string[] fields = line.Split(',');
                this.username = fields[0];
                this.password = fields[1];
                this.firstname = fields[2];
                this.lastname = fields[3];
                this.phone = Convert.ToInt64(fields[4]);
                this.room = Convert.ToInt32(fields[5]);
                this.birthdate = fields[6];
            }
        }
        public bool IsUpdated
        {
            get;
            set;
        }
        public void AddInfo(string username, string password, string firstname, string lastname, long phone, int room, string birth)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter("user_info.txt", true))
                {
                    sw.WriteLine($"{this.username},{this.password},{this.firstname},{this.lastname},{this.phone},{this.room},{this.birthdate}");
                    sw.Close();
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Something went wrong...", ex);
            }
        }
        public void EditInfo(string newLine, int lineToEdit)
        {
            try
            {
                string[] arrLine = File.ReadAllLines("user_info.txt");
                newLine = $"{this.username},{this.password},{this.firstname},{this.lastname},{this.phone},{this.room},{this.birthdate}";
                arrLine[lineToEdit] = newLine;
                File.WriteAllLines("user_info.txt", arrLine);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something went wrong...", ex);
            }
        }

        public bool UserLogin(string username, string password)
        {
            try
            {
                string[] lines = File.ReadAllLines("user_info.txt");
                foreach(var line in lines)
                {
                    string[] fields = line.Split(',');
                    if(this.username == fields[0] && this.password == fields[1])
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something went wrong...", ex);
            }
        }


        public string Username
        {
            get{ return this.username; }
            set { this.username = value; }
        }
        public string Password
        {
            get { return this.password; }
            set {this.password = value; }
        }
        public string FirstName
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }
        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }
        public long PhoneNumber
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public int RoomNumber
        {
            get { return this.room; }
            set { this.room = value; }
        }
        public string BirthDate
        {
            get { return this.birthdate; }
            set { this.birthdate = value ; }
        }

    }
}
