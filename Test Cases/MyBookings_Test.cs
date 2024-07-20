using PHPTRAVELS_NET.Configuration_Files;
using PHPTRAVELS_NET.Page_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTRAVELS_NET.Test_Cases
{
    public class MyBookings_Test : Config
    {
        public void MyBookings_Module()
        {
            MyBookings bookings = new MyBookings(driver);
            bookings.Bookings();
        }
    }
}
