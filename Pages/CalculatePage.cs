using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecflow_BDDFramework.Pages
{
    public class CalculatePage
    {
        IWebDriver driver;

        public void initialize()
        {
            driver = new ChromeDriver(@"C:\Users\Trupti\Downloads");
            driver.Navigate().GoToUrl("https://www.calculator.net/");
        }

        public void EnterNumber(string no)
        {
            IWebElement number;
            char[] ch = no.ToCharArray();

            for (int i = 0; i < no.Length; i++)
            {
                number = driver.FindElement(By.XPath("//span[@onclick='r(" + ch[i] + ")']"));
                number.Click();
            }
        }

        public void ClickonOperator(string op)
        {
            IWebElement op_element = driver.FindElement(By.XPath("//span[@onclick=\"r('" + op + "')\"]"));
            op_element.Click();
        }

        public string VerifyResult()
        {
            IWebElement result = driver.FindElement(By.Id("sciOutPut"));
            string actual_result = result.Text.Trim();
            return actual_result;
        }
       
        public void CloseDriver()
        { 
            driver.Close();
        }

    }
}
