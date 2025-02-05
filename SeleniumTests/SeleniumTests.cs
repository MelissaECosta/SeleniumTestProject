using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests;

public class SeleniumTests
{
    [Test]
    [Category("Selenium")]
    public void FirstTest()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.selenium.dev/");
        Assert.That(driver.Title, Is.EqualTo("Selenium"));
        driver.Quit();
    }

    [Test]
    public void SecondTest()
    {
        IWebDriver driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
        driver.Navigate().GoToUrl("https://www.selenium.dev/");
        Assert.That(driver.Title, Is.EqualTo("Selenium"));
        driver.Quit();
    }
}
