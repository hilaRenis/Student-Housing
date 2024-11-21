using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class Room
    {
        private string roomName;
        private RoomTypes roomType;

        public Room(string roomName, RoomTypes roomType)
        {
            this.roomName = roomName;
            this.roomType = roomType;
        }

        public string Getinfo()
        {
            string info = $"{roomName} - {roomType}";
            return info;
        }
    }
}
