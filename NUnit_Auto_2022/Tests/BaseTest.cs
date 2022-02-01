using NUnit.Framework;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class BaseTest
    {
        public IWebDriver driver;

        // Before each test
        [SetUp]
        public void Setup()
        {
            // Instantiate the browser using the Browser Factory class created in Utilities
            driver = Browser.GetDriver(WebBrowsers.Chrome);
        }

        // After each test
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
