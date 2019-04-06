using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace seleniumtest
{
    public class VkLogin
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://vk.com/";

            IWebElement username = driver.FindElement(By.Id("index_email"));
            username.SendKeys("alena.velitskaya@gmail.com");

            IWebElement password = driver.FindElement(By.Id("index_pass"));
            password.SendKeys("123");

            IWebElement login = driver.FindElement(By.Id("index_login_button"));
            login.Click();
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
