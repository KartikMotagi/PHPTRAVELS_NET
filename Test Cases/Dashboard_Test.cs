using Newtonsoft.Json;
using PHPTRAVELS_NET.Configuration_Files;
using PHPTRAVELS_NET.Page_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTRAVELS_NET.Test_Cases
{
    public class Dashboard_Test : Config
    {
        public dynamic GetTestDataFromJson()
        {
            // Read the JSON file and parse it as dynamic
            string jsonFilePath = "C:\\Users\\KTS\\source\\repos\\PHPTRAVELS_NET\\Utility Files\\TravelData.json";
            string jsonData = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject(jsonData);
        }
        public void Dashboard_Module()
        {
            // Get the test data from the JSON file
            dynamic testData = GetTestDataFromJson();

            foreach (var data in testData)
            {
                string From = data.FROM;
                string To = data.TO;

                string fnt1 = data.T1FirstName;
                string lnt1 = data.T1LastName;
                string idt1 = data.T1ID;

                string fnt2 = data.T2FirstName;
                string lnt2 = data.T2LastName;
                string idt2 = data.T2ID;

                string fnt3 = data.T3FirstName;
                string lnt3 = data.T3LastName;
                string idt3 = data.T3ID;

                Dashboard dash = new Dashboard(driver);
                dash.Dashboard_Info(From, To);
                dash.Info();
                dash.Traveller1(fnt1, lnt1, idt1);
                dash.Traveller2(fnt2, lnt2, idt2);
                dash.Traveller3(fnt3, lnt3, idt3);

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);


            }
        }
    }
}
