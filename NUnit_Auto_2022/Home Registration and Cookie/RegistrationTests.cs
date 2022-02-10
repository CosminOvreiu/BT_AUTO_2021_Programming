using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnit_Auto_2022.Home_Registration_and_Cookie
{
    class RegistrationTests
    {
        IWebDriver driver;
        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string basePath = "/#/";
        const string path = "registration";
        public static string userName = "Boby";
        public static string password = "parola1122";
        public static string firstName = "Pompiliu";
        public static string lastName = "Bogdan";
        public static string email = "b@p.com";
        public static string dateOfbirth = "01/08/1980";
        public static string nationality = "Italian";



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

            var pageText = driver.FindElement(By.XPath("//div[@class='row']//h1//small[@class='text-muted']"));
            Assert.AreEqual("Registration", pageText.Text);

            var usernameTextBox = driver.FindElement(By.XPath("//input[@id='input-username']"));
            usernameTextBox.SendKeys(userName);

            var passwordTextBox = driver.FindElement(By.XPath("//input[@id='input-password']"));
            passwordTextBox.SendKeys(password);

            var confirmPasswordTextBox = driver.FindElement(By.XPath("//input[@id='input-password-confirm']"));
            confirmPasswordTextBox.SendKeys(password);

            driver.FindElement(By.XPath("//label[text()='Mr']//preceding-sibling::input")).Click();

            var firstNameTextBox = driver.FindElement(By.XPath("//input[@id='input-first-name']"));
            firstNameTextBox.SendKeys(firstName);

            var lastNameTextBox = driver.FindElement(By.XPath("//input[@id='input-last-name']"));
            lastNameTextBox.SendKeys(lastName);







            Thread.Sleep(5000);

/*            var loginLink = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(2)"));
            loginLink.Click();
            Console.WriteLine(loginLink.GetAttribute("href"));

            pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Authentication", pageText.Text);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form > div:nth-child(3) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));

            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            submit.Submit();

            Assert.AreEqual(userErr, usernameError.Text);
            Assert.AreEqual(passErr, passwordError.Text);*/



        }







        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
