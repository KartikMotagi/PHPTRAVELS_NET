using PHPTRAVELS_NET.Configuration_Files;
using PHPTRAVELS_NET.Test_Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTRAVELS_NET.Test_Suites
{
    [TestFixture]

    [Category("Test Suites")]
    public class Suites : Config
    {
        [Test, Order(1)]
        
        public void Login()
        {
            Login_Test log = new Login_Test();
            log.Login_Module();
        }

        [Test, Order(2)]
        
        public void Dashboard()
        {
            Dashboard_Test dash = new Dashboard_Test();
            dash.Dashboard_Module();
        }

        [Test, Order(3)]
        public void MyBookings()
        {
            MyBookings_Test booking = new MyBookings_Test();
            booking.MyBookings_Module();

        }
    }
}
