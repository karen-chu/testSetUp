using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSetUp
{
    public class Class1
    {
        IWebDriver driver; 

        [SetUp]
        public void Initialize()
        {
            //create chrome driver instance
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
        }

        [Test]
        public void LaunchPage()
        {
            Assert.IsTrue(driver.PageSource.Contains("hpcanvas"));
            Assert.IsTrue(driver.PageSource.Contains("Google Search"));
            Assert.IsTrue(driver.PageSource.Contains("gb"));

        }
        
        [Test]
        public void SearchItems()
        {
            driver.FindElement(By.CssSelector(".gLFyf")).SendKeys("Selenium");
        }


        [TearDown]
        public void ShutDown()
        {
            driver.Close();
        }



    }
}
