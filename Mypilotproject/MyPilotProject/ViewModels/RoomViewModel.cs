using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using MyPilotProject.Models;

namespace MyPilotProject.ViewModels
{
    public class RoomViewModel
    {
        private SalesDetail _salesDetail;

        public RoomViewModel(SalesDetail salesDetail)
        {
            this._salesDetail = salesDetail;
        }

        public int OrderQty { get { return _salesDetail.OrderQty; } }
        public int UnitPrice { get { return _salesDetail.UnitPrice; } }

        public string ProductName { get { return _salesDetail.ProductName; } }
        public int SalesOrderID { get { return _salesDetail.SalesOrderID; } }


        public SalesDetail SalesDetail
        {
            get => _salesDetail;
        }

    }
}
