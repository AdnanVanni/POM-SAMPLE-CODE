using Exercise;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Tests
{
    public class Tests
    {
        IWebDriver dr;
        [SetUp]
        public void Setup()
        {
            dr = new FirefoxDriver();
        }

        [Test]
        public void SearchComplicatedPageandOpen()
        {
            ;
            POHome Home = new POHome(dr);
            Home.Open("https://ultimateqa.com/");
            Home.Search("complicated page");
            SearchResults SR = new SearchResults(dr);
            SR.findParticularLinkAndClickOnIt("Complicated Page");
            Assert.AreEqual(dr.Title, "Complicated Page | Ultimate QA");
        }
        [TearDown]
        public void Close()
        {
            dr.Close();
        }
    }
}