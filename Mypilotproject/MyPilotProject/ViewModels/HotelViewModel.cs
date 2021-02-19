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

        internal HotelViewModel(SalesListItem salesListItem, bool expanded = false)
        {
            this.SalesListItem = salesListItem;
            this._expanded = expanded;
            hotelRooms.Add(new RoomViewModel(salesListItem.Detail));
            
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
        public int id { get { return SalesListItem.id; } }

        public SalesDetail Detail { get { return SalesListItem.Detail; } }
        public string Customer { get { return SalesListItem.Customer; } }
        public string OrderDate { get { return SalesListItem.OrderDate; } }
        public string SalesOrder { get { return SalesListItem.SalesOrder; } }
        public string SalesPerson { get { return SalesListItem.SalesPerson; } }
        public int TotalAmount { get { return SalesListItem.TotalAmount; } }
        internal SalesListItem SalesListItem { get; set; }

    }
}
