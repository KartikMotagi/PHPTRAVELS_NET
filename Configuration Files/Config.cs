using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace PHPTRAVELS_NET.Configuration_Files
{
    [TestFixture]
    public class Config
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            // Setup ChromeDriver using WebDriverManager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // Create ChromeDriver instance
            driver = new ChromeDriver();

            // Maximize the browser window
            driver.Manage().Window.Maximize();

            // Navigate to the URL
            driver.Url = "https://phptravels.net/login";

            // Set implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            // Quit the driver
            driver.Quit();
        }
    }
}