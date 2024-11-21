using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Agency
{
    public class ManageBuildingLayout
    {
        private List<Room> roomList;

        public ManageBuildingLayout()
        {
            roomList = new List<Room>();
        }

        public void AddRoom(string RoomName, RoomTypes RoomType)
        {
            Room NewRoom = new Room(RoomName, RoomType);
            roomList.Add(NewRoom);
        }

        public void RemoveRoom(int RoomIndex)
        {
            RoomList.RemoveAt(RoomIndex);
        }

        public List<Room> RoomList
        {
            get
            {
                return roomList;
            }
        }
    }
}
