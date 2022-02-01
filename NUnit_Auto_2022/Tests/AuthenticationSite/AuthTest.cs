using NUnit.Framework;
using NUnit_Auto_2022.PageModels1.POM;
using NUnit_Auto_2022.PageModels1.PageFactory;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class AuthTest : BaseTest
    {

        string url = FrameworkConstants.GetUrl();


        // Test auth with Page Object model
        [Test]
        public void BasicAuth()
        {
            driver.Navigate().GoToUrl(url + "login");
            // This is beacuse we have 2 classes named LoginPage one on POM other on PageFactory
            // In real life framework you will have just one type of desigm pattern (POM/PF)
            PageModels1.POM.LoginPage lp = new PageModels1.POM.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");
        }

        // Test auth with Page factory
        [Test]
        public void BasicAuthPf()
        {
            driver.Navigate().GoToUrl(url + "login");
            PageModels1.PageFactory.LoginPage lp = new PageModels1.PageFactory.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");
        }



    }
}
