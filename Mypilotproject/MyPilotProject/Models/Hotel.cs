using System;
using System.Collections.Generic;
using System.Text;

namespace MyPilotProject.Models
{
    class Hotel
    {
        public string Name { get; set; }

        public List<SalesDetail> Rooms { get; set; }

        public bool IsVisible { get; set; } = false;

        public Hotel()
        {
        }

        public Hotel(string name, List<SalesDetail> rooms)
        {
            Name = name;
            Rooms = rooms;
        }
    }
}
