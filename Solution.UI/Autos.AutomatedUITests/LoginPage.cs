using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autos.AutomatedUITests
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private const string URI = "http://localhost:53259/Identity/Account/Login";
        private IWebElement EmailElement => _driver.FindElement(By.Id("Email"));
        private IWebElement PasswordElement => _driver.FindElement(By.Id("Password"));
        private IWebElement LoginElement => _driver.FindElement(By.Id("Login"));
        public string Title => _driver.Title;
        public string Source => _driver.PageSource;
        public string AccountPasswordErrorMessage => _driver.FindElement(By.Id("AccountPassword-error")).Text;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void Navigate() => _driver.Navigate()
               .GoToUrl(URI);
        public void PopulateEmail(string email) => EmailElement.SendKeys(email);
        public void PopulatePassword(string password) => PasswordElement.SendKeys(password);
        public void ClickCreate() => LoginElement.Click();
    }
}