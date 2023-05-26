using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SeleniumSpecflow_BDDFramework.Pages;
using OpenQA.Selenium;

namespace SeleniumSpecflow_BDDFramework.Steps
{
    [Binding]
    public class CalculateStepDefinitions
    {
        CalculatePage calcPage;
        public CalculateStepDefinitions(CalculatePage calcPage1)
        {
            this.calcPage = calcPage1;
        }

        [Given(@"User visits Calculator web page")]
        public void GivenUserVisitsCalculatorWebPage()
        {
            calcPage.initialize();
        }

        [When(@"User clicks on number '([^']*)'")]
        public void WhenUserClicksOnNumber(string no)
        {
            calcPage.EnterNumber(no);
        }

        [When(@"User clicks on '([^']*)'")]
        public void WhenUserClicksOn(string op)
        {
            calcPage.ClickonOperator(op);
        }
    
        [Then(@"User verifies Result '([^']*)'")]
        public void ThenUserVerifiesResult(string expectedresult)
        {
            string actualresult = calcPage.VerifyResult();
            Assert.Equal(expectedresult, actualresult);
            calcPage.CloseDriver();
        }

    }
}
