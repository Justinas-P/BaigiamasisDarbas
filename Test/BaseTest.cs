using KnygosLt.Drivers;
using KnygosLt.Page;
using KnygosLt.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnygosLt.Test
{
    public class BaseTest
    {
        protected static IWebDriver driver;
        public static KnygosLtMainPage page;
        public static KnygosLtLoginPage loginPage;
        public static KnygosLtCartPage cartPage;


        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();


            page = new KnygosLtMainPage(driver);
            loginPage = new KnygosLtLoginPage(driver);
            cartPage = new KnygosLtCartPage(driver);
        }

        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreeshot(driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }
    }
}
