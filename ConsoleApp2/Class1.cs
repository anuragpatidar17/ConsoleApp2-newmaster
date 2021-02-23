using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;


namespace ConsoleApp2
{

    public class Class1
    {
        [Test]
        public void SearchForWord()
        {
            var driver = new ChromeDriver();

            {

                driver.Navigate().GoToUrl("https://mds-test.shell.com/");


                


                Console.WriteLine(driver.Title);


                



                driver.Quit();
            }

        }
    }
}
