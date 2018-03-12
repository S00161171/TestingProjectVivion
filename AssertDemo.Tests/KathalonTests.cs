using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Supertest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheSuperTest()
        {
            driver.Navigate().GoToUrl("http://localhost:3028/");
            driver.FindElement(By.Id("genderIn")).Click();
            driver.FindElement(By.Id("genderIn")).Clear();
            driver.FindElement(By.Id("genderIn")).SendKeys("Female");
            driver.FindElement(By.Id("ageIn")).Clear();
            driver.FindElement(By.Id("ageIn")).SendKeys("17");
            driver.FindElement(By.Id("btn")).Click();
            driver.FindElement(By.Id("premium")).Click();
            Assert.AreEqual("Premium = 0.0", driver.FindElement(By.Id("premium")).GetAttribute("value"));
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }

        [Test]
        public void TheSuperTest1()
        {
            driver.Navigate().GoToUrl("http://localhost:3028/");
            driver.FindElement(By.Id("genderIn")).Click();
            driver.FindElement(By.Id("genderIn")).Clear();
            driver.FindElement(By.Id("genderIn")).SendKeys("Female");
            driver.FindElement(By.Id("ageIn")).Clear();
            driver.FindElement(By.Id("ageIn")).SendKeys("30");
            driver.FindElement(By.Id("btn")).Click();
            driver.FindElement(By.Id("premium")).Click();
            Assert.AreEqual("Premium = 5.0", driver.FindElement(By.Id("premium")).GetAttribute("value"));
        }
        private bool IsElementPresent1(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent1()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText1()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
        [Test]
        public void TheSuperTest2()
        {
            driver.Navigate().GoToUrl("http://localhost:3028/");
            driver.FindElement(By.Id("genderIn")).Click();
            driver.FindElement(By.Id("genderIn")).Clear();
            driver.FindElement(By.Id("genderIn")).SendKeys("Female");
            driver.FindElement(By.Id("ageIn")).Clear();
            driver.FindElement(By.Id("ageIn")).SendKeys("32");
            driver.FindElement(By.Id("btn")).Click();
            driver.FindElement(By.Id("premium")).Click();
            Assert.AreEqual("Premium = 2.50", driver.FindElement(By.Id("premium")).GetAttribute("value"));
        }
        private bool IsElementPresent2(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent2()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText2()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
        [Test]
        public void TheSuperTest3()
        {
            driver.Navigate().GoToUrl("http://localhost:3028/");
            driver.FindElement(By.Id("genderIn")).Click();
            driver.FindElement(By.Id("genderIn")).Clear();
            driver.FindElement(By.Id("genderIn")).SendKeys("Male");
            driver.FindElement(By.Id("ageIn")).Clear();
            driver.FindElement(By.Id("ageIn")).SendKeys("17");
            driver.FindElement(By.Id("btn")).Click();
            driver.FindElement(By.Id("premium")).Click();
            Assert.AreEqual("Premium = 0.0", driver.FindElement(By.Id("premium")).GetAttribute("value"));
        }
        private bool IsElementPresent3(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent3()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText3()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
        [Test]
        public void TheSuperTest4()
        {
            driver.Navigate().GoToUrl("http://localhost:3028/");
            driver.FindElement(By.Id("genderIn")).Click();
            driver.FindElement(By.Id("genderIn")).Clear();
            driver.FindElement(By.Id("genderIn")).SendKeys("Male");
            driver.FindElement(By.Id("ageIn")).Clear();
            driver.FindElement(By.Id("ageIn")).SendKeys("34");
            driver.FindElement(By.Id("btn")).Click();
            driver.FindElement(By.Id("premium")).Click();
            Assert.AreEqual("Premium = 6.0", driver.FindElement(By.Id("premium")).GetAttribute("value"));
        }
        private bool IsElementPresent4(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent4()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText4()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}