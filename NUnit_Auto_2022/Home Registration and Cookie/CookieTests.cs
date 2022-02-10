using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Home_Registration_and_Cookie
{
    class CookieTests
    {
        IWebDriver driver;
        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string basePath = "/#/";
        const string path = "cookie";
        public static string GetCookieNamed;



        string url = protocol + "://" + hostname + ":" + port + basePath + path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }


        [Test]
        public void Test01()
        {
            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);
            


            var setTheCookie = driver.FindElement(By.XPath("//button[@id='set-cookie']"));
            setTheCookie.Click();

            var generatedCookie = driver.FindElement(By.XPath("//h1[@id='cookie-value']")).Text;
            Console.WriteLine(generatedCookie);

            
            //Cookie GetCookieNamed("gibberish");
            //var gibberishCookie = cookie.GetCookieNamed("gibberish");
            //Console.WriteLine(gibberishCookie);
        }







        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
