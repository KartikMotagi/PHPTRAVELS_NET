using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTRAVELS_NET.Page_Models
{
    public class Login
    {
        public IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")] IWebElement Email;

        [FindsBy(How = How.Id, Using = "password")] IWebElement Password;

        [FindsBy(How = How.Id, Using = "submitBTN")] IWebElement LoginBtn;

        [FindsBy(How = How.XPath, Using = "//a[text()='Home']")] IWebElement HomeLink;

        public void Login_Info(String email, String password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
            LoginBtn.Click();
            Thread.Sleep(5000);
        }
    }
}
