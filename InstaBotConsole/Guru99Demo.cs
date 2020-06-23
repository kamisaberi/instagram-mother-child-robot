using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBotConsole
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\3rdparty\\chrome");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
