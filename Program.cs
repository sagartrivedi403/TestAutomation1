using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLoginTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Launch the chrome browser
            IWebDriver driver = new ChromeDriver();

            //Maximise the browser
            driver.Manage().Window.Maximize();

            //Launch the Turnup portal
            driver.Navigate().GoToUrl("https://horse-dev.azurewebsites.net/Account/Login");

            //Enter correct username
            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("hari");

            //Enter correct password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //Click on the login button
            IWebElement Login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            Login.Click();

            //Validate if the user had logged in successfully or not
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, Login test passed");
            }
            else
            {
                Console.WriteLine("Login failded, test failed");
            }
        }
    }
}
