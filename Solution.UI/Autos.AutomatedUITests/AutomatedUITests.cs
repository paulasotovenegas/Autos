using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace Autos.AutomatedUITests
{
    public class AutomatedUITests : IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _page;
        public AutomatedUITests()
        {
            _driver = new ChromeDriver();
            _page = new LoginPage(_driver);
            _page.Navigate();
        }
        [Fact]
        public void Create_WhenExecuted_ReturnsCreateView()
        {
            Assert.Equal("Create - Login", _page.Title);
            Assert.Contains("Por favor ingrese datos del login", _page.Source);
        }
        [Fact]
        public void Create_WrongModelData_ReturnsErrorMessage()
        {
            _page.PopulateEmail("");
            
            _page.ClickCreate();
            Assert.Equal("La contraseña es requerida", _page.AccountPasswordErrorMessage);
        }
        [Fact]
        public void Create_WhenSuccessfullyExecuted_ReturnsIndexViewWithNewEmployee()
        {
            _page.PopulateEmail("paula.soto1399@gmail.com");
            _page.PopulatePassword("Sistemas-19");
            _page.ClickCreate();
            Assert.Equal("Index - Home", _page.Title);
            Assert.Contains("paula.soto1399@gmail.com", _page.Source);
            Assert.Contains("Sistemas-19", _page.Source);
    
        }
        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}