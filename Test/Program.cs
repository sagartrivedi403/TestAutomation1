using FirstLoginTest.Helpers;
using FirstLoginTest.Pages;
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
        public static void Main(string[] args)
        {
            //define driver
            CommonDriver.driver = new ChromeDriver();
            //Login action
            Login loginObj = new Login();
            loginObj.loginsteps1(CommonDriver.driver);

            //navigate to TM
            Homepage homeObj = new Homepage();
            homeObj.navigatetoTM(CommonDriver.driver);

            //Create TM
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(CommonDriver.driver);

        }
    }
}
