using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class SearchResults
    {
        IWebDriver dr;
        public SearchResults(IWebDriver dr)
        {
            this.dr = dr;

        }
        public void findParticularLinkAndClickOnIt(string val)
        {
            By linked = By.LinkText(val);
            dr.FindElement(linked).Click();
          
        }
    }
}
