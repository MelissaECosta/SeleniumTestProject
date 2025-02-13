using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests;

public class EdurekaTests
{
    [Test]
    [Category("Selenium")]
    public void GetTitle()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.edureka.co/");
        driver.Manage().Window.Maximize();
        System.Console.WriteLine("The Title is '" + driver.Title + "'");
        driver.Quit();
    }

    [Test]
    [Category("Selenium")]
    public void GetTitleFirefox()
    {
        IWebDriver driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
        driver.Navigate().GoToUrl("https://www.edureka.co/");
        driver.Manage().Window.Maximize();
        System.Console.WriteLine("The Title is '" + driver.Title + "'");
        driver.Quit();
    }

    [Test]
    [Category("Selenium")]
    public void GmailTitleTest()
    {
        IWebDriver driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
        driver.Navigate().GoToUrl("https://www.gmail.com/");
        driver.Manage().Window.Maximize();
        driver.FindElement(By.Id("identifierId")).SendKeys("melissa.e.costa@gmail.com");
        driver.FindElement(By.ClassName("TNTaPb")).Click();
        String at = driver.Title;
        String et = "gmail";
        driver.Quit();
        if (at.ToUpper() == et.ToUpper())
        {
            System.Console.WriteLine("Test Passed");
        }
        else
        {
            System.Console.WriteLine("Test Failed");
        }
    }
}