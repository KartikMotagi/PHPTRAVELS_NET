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
    public class Login_Test : Config
    {
        public dynamic GetTestDataFromJson()
        {
            // Read the JSON file and parse it as dynamic
            string jsonFilePath = "C:\\Users\\KTS\\source\\repos\\PHPTRAVELS_NET\\Utility Files\\LoginData.json";
            string jsonData = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject(jsonData);
        }

        public void Login_Module()
        {
            // Get the test data from the JSON file
            dynamic testData = GetTestDataFromJson();

            foreach (var data in testData)
            {
                string email = data.Email;
                string password = data.Password;

                Login log = new Login(driver);
                log.Login_Info(email, password);

            }
        }
    }
}
