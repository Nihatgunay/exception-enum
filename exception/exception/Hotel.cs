using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[] rooms;
        public Hotel()
        {
            rooms = new Room[0];
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[^1] = room;
        }
        public void MakeReservation(int? roomid)
        {
            if (roomid == null)
            {
                throw new NotAvailableException("id cannot be blank");
            }
            Room room = null;
            foreach (var a in rooms )
            {
                if (a.Id == roomid)
                {
                    room = a; break;
                }
            }
            if (!room.IsAvailable)
            {
                throw new NotAvailableException("room is not available");
            }
            else
            {
                room.IsAvailable = false;
            }
        }

    }
}
