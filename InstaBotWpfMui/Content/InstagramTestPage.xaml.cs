using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace InstaBotWpfMui.Content
{
    /// <summary>
    /// Interaction logic for InstagramTestPage.xaml
    /// </summary>
    public partial class InstagramTestPage : UserControl
    {
        public InstagramTestPage()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            //IWebDriver driver = new ChromeDriver(service,option);
            //IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new ChromeDriver(option);
            IWebDriver driver = new ChromeDriver(service);
            // navigate to URL  
            driver.Navigate().GoToUrl("https://www.instagram.com/");
            Thread.Sleep(2000);

            IWebElement username= driver.FindElement(By.Name("username"));
            new Actions(driver).MoveToElement(username).Click().Build().Perform();
            username.SendKeys("kam");
            username.SendKeys("isa");
            username.SendKeys("beri");
            Thread.Sleep(1000);

            IWebElement password = driver.FindElement(By.Name("password"));
            new Actions(driver).MoveToElement(password).Click().Build().Perform();
            password.SendKeys("Neme");
            password.SendKeys("sis");
            password.SendKeys("1358");
            Thread.Sleep(1000);

            IWebElement btnSubmmit= driver.FindElement(By.CssSelector("button[type='submit']"));
            btnSubmmit.Click();

            Thread.Sleep(5000);

            try
            {
                driver.FindElement(By.XPath("//*[contains(text(), 'Not Now')]")).Click();
                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {

            }

            try
            {
                driver.FindElement(By.XPath("//*[contains(text(), 'Not Now')]")).Click();
                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {

            }


            // identify the Google search text box  
            //driver.Quit();


            //IWebElement ele = driver.FindElement(By.Name("q"));
            ////enter the value in the google search text box  
            ////ele.Click();
            //ele.SendKeys("javatpoint tutorials");
            //Thread.Sleep(2000);
            ////identify the google search button  
            //IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            //// click on the Google search button  
            //ele1.Click();
            //Thread.Sleep(3000);
            ////close the browser  
            ////driver.Close();
            //Console.Write("test case ended ");
        }
    }
}
