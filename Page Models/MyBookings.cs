using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTRAVELS_NET.Page_Models
{
    public class MyBookings
    {
        IWebDriver driver;

        public MyBookings(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//a[@href='https://phptravels.net/bookings'])[2]")] IWebElement My_Booking_Menu;

        [FindsBy(How = How.XPath, Using = "(//a[@target='_blank'])[1]")] IWebElement Invoice;

        [FindsBy(How = How.XPath, Using = "//strong[@class='m-0 text-dark text-uppercase']")] IWebElement Account;

        [FindsBy(How = How.XPath, Using = "(//a[@href=\"https://phptravels.net/logout\"])[1]")] IWebElement Logout;

        public void Bookings()
        {
            My_Booking_Menu.Click();
            Thread.Sleep(3000);

            Invoice.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(3000);
            driver.Close();

            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(3000);

            Account.Click();
            Thread.Sleep(3000);

            Logout.Click();
            Thread.Sleep(2000);


        }
    }
}
