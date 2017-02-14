using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace domainLoadValidation.PageObjects
{
    class DomainHomePage
    {
        public IWebDriver driver;

        internal void OpenDomainInChrome()
        {

            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(120));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.domain.com.au/");
     
            
        }

        

        internal void ClickMenu(string menu)
        {
            switch (menu)
            {

                case "buy":
                    driver.FindElement(By.LinkText("Buy")).Click();
                    break;
                case "rent":
                    driver.FindElement(By.LinkText("Rent")).Click();
                    break;
                case "sold":
                    driver.FindElement(By.LinkText("Sold")).Click();
                    break;
                case "newhome":
                    driver.FindElement(By.LinkText("New Homes")).Click();
                    break;
                case "commercial":
                    driver.FindElement(By.LinkText("Commercial")).Click();
                    break;
                case "news":
                    driver.FindElement(By.LinkText("News")).Click();
                    break;
                case "advice":
                    driver.FindElement(By.LinkText("Advice")).Click();
                    break;
                case "agents":
                    driver.FindElement(By.LinkText("Agents")).Click();
                    break;
            }

        }




        internal void PageLoaded(string menuSelected)
        {
            string menucheckitem;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

            switch (menuSelected)
            {

                case "buy":
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ui-selectmenu-text")));
                    menucheckitem = driver.FindElement(By.ClassName("ui-selectmenu-text")).Text;
                    if (menuSelected.ToLower() != menucheckitem.ToLower())
                    {
                        Assert.Fail("The page " + menuSelected + " is not loaded");

                    }
                    break;
                case "rent":
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ui-selectmenu-text")));
                    menucheckitem = driver.FindElement(By.ClassName("ui-selectmenu-text")).Text;

                    if (menuSelected.ToLower() != menucheckitem.ToLower())
                    {
                        Assert.Fail("The page " + menuSelected + " is not loaded");

                    }
                    break;
                case "sold":
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ui-selectmenu-text")));
                    menucheckitem = driver.FindElement(By.ClassName("ui-selectmenu-text")).Text;

                    if (menuSelected.ToLower() != menucheckitem.ToLower())
                    {
                        Assert.Fail("The page " + menuSelected + " is not loaded");

                    }
                    break;

                case "newhome":
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("new-homes-tagline")));
                    menucheckitem = driver.FindElement(By.ClassName("new-homes-tagline")).Text;
                    Console.WriteLine("the menuslected" + menuSelected + "It is displayed" + menucheckitem);
                    if (menucheckitem != "Find New Homes")
                    {
                        Assert.Fail("The page " + menuSelected + " is not loaded");
                       
                    }
                    break;

                case "commercial":
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("homepage-tag-line")));
                    menucheckitem = driver.FindElement(By.ClassName("homepage-tag-line")).Text;
                    Console.WriteLine("the menuslected" + menuSelected + "It is displayed" + menucheckitem);
                    if (menucheckitem != "Find commercial real estate for sale and for lease")
                    {
                        Assert.Fail("The page " + menuSelected + " is not loaded");

                    }
                    break;
                case "news":
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("article-list")));
                    menucheckitem = driver.FindElement(By.ClassName("article-list")).Text;
                    Console.WriteLine("the menuslected" + menuSelected + "It is displayed" + menucheckitem);
                    if (!menucheckitem.Contains("LATEST REAL ESTATE & PROPERTY MARKET NEWS"))
                    {
                        Assert.Fail("The page " + menuSelected + " is not loaded");

                    }
                    break;
                case "advice":
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("advice-category-title")));
                    menucheckitem = driver.FindElement(By.ClassName("advice-category-title")).Text;
                    Console.WriteLine("the menuslected" + menuSelected + "It is displayed" + menucheckitem);
                    if (menucheckitem != "Advice")
                    {
                        Assert.Fail("The page " + menuSelected + " is not loaded");

                    }
                    break;
                case "agents":
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("find-an-agent__radio-inputs-label")));
                    menucheckitem = driver.FindElement(By.ClassName("find-an-agent__radio-inputs-label")).Text;
                    Console.WriteLine("the menuslected" + menuSelected + "It is displayed" + menucheckitem);
                    if (menucheckitem != "AGENCY")
                    {
                        Assert.Fail("The page " + menuSelected + " is not loaded");

                    }
                    break;


            }

            driver.Quit();
           
            
        }
       
    }
}
