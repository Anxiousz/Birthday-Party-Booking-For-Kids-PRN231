﻿using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IRoomRepository
    {
        public List<Room> GetAllRoomById(int id);
        public Room getRoomById(int id);
        public void CreateNewRoom(Room room);
        public void UpdateStatusRoom(Room room);
        public bool UpdateRoom(int id, Room updatedRoom);
    }
}
