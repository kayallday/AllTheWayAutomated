using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;

namespace AllTheWayAutomatedTests.PageObjects
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public void VisitCustomerLogin()
        {
            Visit("");
            By CustomerLoginButton = SelectorByAttributeValue("ng-click", "customer()");
            WaitUntilDisplayed(CustomerLoginButton, WAIT_SECONDS);
            Click(CustomerLoginButton);
        }
    }
}
