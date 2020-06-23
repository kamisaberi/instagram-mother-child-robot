using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace InstaBotWpfMui.Content
{
    /// <summary>
    /// Interaction logic for LoremIpsum.xaml
    /// </summary>
    public partial class LoremIpsum : UserControl
    {
        public LoremIpsum()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = false;
            Console.Write("test case started ");
            //create the reference for the browser  
            //IWebDriver driver = new ChromeDriver(service,option);
            //IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new ChromeDriver(option);
            IWebDriver driver = new ChromeDriver(service);
            // navigate to URL  
            driver.Navigate().GoToUrl("https://www.python.org/");
            Thread.Sleep(2000);
            // identify the Google search text box  
            driver.Quit();


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
