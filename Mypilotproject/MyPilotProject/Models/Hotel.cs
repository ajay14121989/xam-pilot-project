using System;
using System.Collections.Generic;
using System.Text;

namespace MyPilotProject.Models
{
    class Hotel
    {
        public string Name { get; set; }

        public List<Room> Rooms { get; set; }

        public bool IsVisible { get; set; } = false;

        public Hotel()
        {
        }

        public Hotel(string name, List<Room> rooms)
        {
            Name = name;
            Rooms = rooms;
        }
    }
}
