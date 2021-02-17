using MvvmHelpers;
using MyPilotProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyPilotProject.ViewModels
{
    public class HotelViewModel : ObservableRangeCollection<RoomViewModel>, INotifyPropertyChanged
    {
        // It's a backup variable for storing CountryViewModel objects
        private ObservableRangeCollection<RoomViewModel> hotelRooms = new ObservableRangeCollection<RoomViewModel>();

        internal HotelViewModel(Hotel hotel, bool expanded = false)
        {
            this.Hotel = hotel;
            this._expanded = expanded;

            foreach (Room room in hotel.Rooms)
            {
                hotelRooms.Add(new RoomViewModel(room));
            }
            if (expanded)
                this.AddRange(hotelRooms);

        }

        public HotelViewModel()
        {
        }

        private bool _expanded;
        public bool Expanded
        {
            get { return _expanded; }
            set
            {
                if (_expanded != value)
                {
                    _expanded = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Expanded"));
                    OnPropertyChanged(new PropertyChangedEventArgs("StateIcon"));
                    if (_expanded)
                    {
                        this.AddRange(hotelRooms);
                    }
                    else
                    {
                        this.Clear();
                    }
                }
            }
        }

        public string StateIcon
        {
            get
            {
                if (Expanded)
                {
                    return "arrow_a.png";
                }
                else
                { return "arrow_b.png"; }
            }
        }
        public string Name { get { return Hotel.Name; } }
        internal Hotel Hotel { get; set; }

    }
}
