using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Exercise
{
    class POHome
    {
        IWebDriver dr;
        public POHome(IWebDriver dr)
            {
            this.dr = dr;
            }
    
        By SearchBox = By.ClassName("et_pb_s");
        
            By sumbit = By.ClassName("et_pb_searchsubmit");
        public void Open(string val)
        {
            dr.Navigate().GoToUrl(val) ;
        }
        public void Search(string val)
        {
            dr.FindElement(SearchBox).SendKeys(val);
            dr.FindElement(sumbit).Click();
        }

        
    }
}
