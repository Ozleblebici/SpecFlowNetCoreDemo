using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowNetCoreDemo.Pages;
using System;

namespace SpecFlowNetCoreDemo
{
    public class Tests : DriverHelper
    {



        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments("headless");
            Driver = new ChromeDriver(chromeOptions);

        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");
            // Driver.FindElement(By.XPath("asd")).SendKeys("");


            Console.WriteLine("PASSes");

            Assert.Pass();



           // CustomControl.ComboBox("AllMealsCombo", "Almond");        
        }

        [Test]
        public void LoginTest()
        {
           

            //HomePage homePage = new HomePage();
            //LoginPage loginPage = new LoginPage();

            //homePage.ClickLogin();
            //loginPage.EnterUserNameAndPassword("admin", "password");
            //loginPage.ClickLogin();

            //Assert.That(homePage.IsLogOffExist(), Is.True, "Log off button did not displayed");



            
        }
    }

}

