using AngleSharp.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTRAVELS_NET.Page_Models
{
    public class Dashboard
    {
        public IWebDriver driver;

        public Dashboard(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href=\"https://phptravels.net/flights\"]")] IWebElement Flights_Menu;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"onereturn\"]/div[1]/div[1]/div[2]/span/span[1]/span")] IWebElement Flying_From;

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")] IWebElement BLR_SEARCH;

        [FindsBy(How = How.XPath, Using = "//button[text()='BLR']")] IWebElement BLR_SELECT;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"onereturn\"]/div[2]/div[2]/div[2]/span/span[1]/span")] IWebElement Destination_To;

        [FindsBy(How = How.XPath, Using = "//input[@type='search']")] IWebElement NEW_SEARCH;

        [FindsBy(How = How.XPath, Using = "//button[text()='NEW']")] IWebElement NEW_SELECT;

        [FindsBy(How = How.Id, Using = "departure")] IWebElement Depart_Date;

        [FindsBy(How = How.XPath, Using = "(//th[@class='switch'])[1]")] IWebElement SELECT_JUNE2024;

        //[FindsBy(How = How.XPath, Using = "//body/div[4]/div[2]/table[1]/thead[1]/tr[1]/th[3]//*[name()='svg']")] IWebElement NEXT_ANGULAR_BTN_2025;

        //[FindsBy(How = How.XPath, Using = "(//td[@colspan='7'])[1]//child::span[12]")] IWebElement DEC_2025;

        //[FindsBy(How = How.Id, Using = "departure")] IWebElement Depart_Date_13_2025;

        //[FindsBy(How = How.XPath, Using = "(//td[@class='day '])[12]")] IWebElement Date_13_2025;

        [FindsBy(How = How.XPath, Using = "(//td[@colspan='7'])[1]//child::span[12]")] IWebElement DEC_2024;

        [FindsBy(How = How.Id, Using = "departure")] IWebElement Depart_Date_13_2024;

        [FindsBy(How = How.XPath, Using = "(//td[@class='day '])[12]")] IWebElement Date_13_2024;

        [FindsBy(How = How.XPath, Using = ("//a[@data-toggle='dropdown']"))] IWebElement Traveller;

        [FindsBy(How = How.XPath, Using = ("(//div[@class='qtyInc'])[1]"))] IWebElement Adult_Passenger;

        [FindsBy(How = How.XPath, Using = "(//div[@class='qtyInc'])[2]")] IWebElement Child_Passenger;

        [FindsBy(How = How.XPath, Using = ("//button[@id='flights-search']"))] IWebElement Fight_Search;

        [FindsBy(How = How.Id, Using = "cookie_stop")] IWebElement Hide_Cookie;

        [FindsBy(How = How.XPath, Using = "//input[@id='oneway_flights_1'  or @id='oneway_flights_0']")] IWebElement Select_AirIndia_OR_Duffel;

        [FindsBy(How = How.XPath, Using = "//button[@class='flex-grow-1 btn btn-outline-primary waves-effect']")] IWebElement More_Details;

        [FindsBy(How = How.XPath, Using = "//button[text()='Select Flight']")] IWebElement Select_Flight;

        [FindsBy(How = How.XPath, Using = "//input[@name='first_name_1']")] IWebElement Traveller1_FN;

        [FindsBy(How = How.XPath, Using = "//input[@name='last_name_1']")] IWebElement Traveller1_LN;

        [FindsBy(How = How.XPath, Using = "//input[@name='passport_1']")] IWebElement Traveller1_PassportID;

        [FindsBy(How = How.XPath, Using = "//input[@name='first_name_2']")] IWebElement Traveller2_FN;

        [FindsBy(How = How.XPath, Using = "//input[@name='last_name_2']")] IWebElement Traveller2_LN;

        [FindsBy(How = How.XPath, Using = "//input[@name='passport_2']")] IWebElement Traveller2_PassportID;

        [FindsBy(How = How.XPath, Using = "//input[@name='first_name_3']")] IWebElement Traveller3_FN;

        [FindsBy(How = How.XPath, Using = "//input[@name='last_name_3']")] IWebElement Traveller3_LN;

        [FindsBy(How = How.XPath, Using = "//input[@name='passport_3']")] IWebElement Traveller3_PassportID;

        //[FindsBy(How = How.XPath, Using = "//input[@id='gateway_bank_transfer']")] IWebElement Payment;

        [FindsBy(How = How.XPath, Using = "//input[@id='agreechb']")] IWebElement TermsAndConditions;

        [FindsBy(How = How.XPath, Using = "//button[@id='booking']")] IWebElement Booking_Confirm;
        

        public void Dashboard_Info(String From, String To)
        {
            Flights_Menu.Click();

            Hide_Cookie.Click();

            Flying_From.Click();
            BLR_SEARCH.SendKeys(From);
            BLR_SELECT.Click();
            Thread.Sleep(3000);

            Destination_To.Click();
            NEW_SEARCH.SendKeys(To);
            NEW_SELECT.Click();
            Thread.Sleep(3000);


            Depart_Date.Click();

            SELECT_JUNE2024.Click();
            DEC_2024.Click();
            Depart_Date_13_2024.Click();
            Thread.Sleep(3000);

            Date_13_2024.Click();
            Thread.Sleep(3000);


            //NEXT_ANGULAR_BTN_2025.Click();
            //DEC_2025.Click();

            //Depart_Date_13_2025.Click();
            //Date_13_2025.Click();

            Traveller.Click();
            Adult_Passenger.Click();
            Thread.Sleep(3000);

            Child_Passenger.Click();
            Thread.Sleep(3000);

            Fight_Search.Click();
            Thread.Sleep(3000);

        }

        public void Info()
        {
            Select_AirIndia_OR_Duffel.Click();
            Thread.Sleep(3000);

            More_Details.Click();
            Thread.Sleep(3000);

            Select_Flight.Click();
            Thread.Sleep(3000);

        }

        public void Traveller1(String First, String Last, String ID)
        {
            Traveller1_FN.SendKeys(First);
            Thread.Sleep(3000);

            Traveller1_LN.SendKeys(Last);
            Thread.Sleep(3000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,300);");

            Traveller1_PassportID.SendKeys(ID);
            Thread.Sleep(3000);

        }

        public void Traveller2(String First, String Last, String ID)
        {
            Traveller2_FN.SendKeys(First);
            Thread.Sleep(3000);

            Traveller2_LN.SendKeys(Last);
            Thread.Sleep(3000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,300);");

            Traveller2_PassportID.SendKeys(ID);
            Thread.Sleep(3000);

        }

        public void Traveller3(String First, String Last, String ID)
        {
            Traveller3_FN.SendKeys(First);
            Thread.Sleep(3000);

            Traveller3_LN.SendKeys(Last);
            Thread.Sleep(3000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,300);");

            Traveller3_PassportID.SendKeys(ID);
            Thread.Sleep(3000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,600);");
            Thread.Sleep(3000);

            //Payment.Click();
            //Thread.Sleep(3000);

            TermsAndConditions.Click();
            Thread.Sleep(3000);

            Booking_Confirm.Click();
            Thread.Sleep(10000);

            driver.Navigate().GoToUrl("https://phptravels.net/dashboard");
            Thread.Sleep(3000);
        }

    }
}
