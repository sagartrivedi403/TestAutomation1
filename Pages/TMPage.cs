using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLoginTest.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("Test123");
            IWebElement Description = driver.FindElement(By.Id("Description"));
            Description.SendKeys("TestDemo");
            IWebElement Save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            Save.Click();
            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            LastPage.Click();
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[1]")).Text== "Test123")
            {
                Console.WriteLine("Code Created Successfully!, Test Passed");
            }
            else
            {
                Console.WriteLine("Try again!, Test Failed");
            }
        }
    }
}