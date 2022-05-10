using Exercise;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
         
        }

        [Test]
        public void Test1()
        {
            IWebDriver dr = new FirefoxDriver();
            POHome Home = new POHome(dr);
            Home.Open("https://ultimateqa.com/");
            Home.Search("complicated page");
            SearchResults SR = new SearchResults(dr);
            SR.findParticularLinkAndClickOnIt("Complicated Page");
            Assert.AreEqual(dr.Title, "Complicated Page | Ultimate QA");
        }
    }
}