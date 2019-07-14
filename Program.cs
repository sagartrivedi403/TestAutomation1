using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            //Create Time and Material test

            //Go to Administration
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //Click on Time & Materials page
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            //Click on Create New button
            IWebElement CNew=driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CNew.Click();
            //Enter code
            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("987");
            //Enter description
            IWebElement Desc = driver.FindElement(By.Id("Description"));
            Desc.SendKeys("Test");
            //Click on save button
            IWebElement Save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            Save.Click();
            Thread.Sleep(1000);
            //Go to last page of the item list
            IWebElement Last = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            Last.Click();
            //Verify the existance of the created record
            if(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]")).Text == "987")
            {
                Console.WriteLine("Record Created Successfully, Test Pass");
            }
            else
            {
                Console.WriteLine("Test Failed, Try Again!");
            }
        }
    }
}
