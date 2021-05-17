using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KnygosLt.Page
{
    public class KnygosLtMainPage : BasePage
    {
        private const string PageAddress = "https://www.knygos.lt/";

        private IWebElement subscriptionEmailField => Driver.FindElement(By.Id("mce-EMAIL"));
        private IWebElement subscriptionButton => Driver.FindElement(By.Id("mc-embedded-subscribe"));
        private IWebElement subscriptionFirstCheckBox => Driver.FindElement(By.CssSelector("#mc_embed_signup_scroll > fieldset > div.custom-control.custom-checkbox.mb-3 > label"));
        private IWebElement subscriptionSecondCheckBox => Driver.FindElement(By.CssSelector("#mc_embed_signup_scroll > fieldset > div:nth-child(2)"));
        private IWebElement subscriptionResult => Driver.FindElement(By.CssSelector("templateBody > h2"));
        private string expectedsubscriptionResult => "Beveik baigta...";
        private IWebElement allowCookieButton => Driver.FindElement(By.CssSelector("#homepage > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-custom.cc-bottom > div.cc-compliance.cc-highlight > a.cc-btn.cc-allow"));
        private IWebElement searchField => Driver.FindElement(By.Id("product-search")); 
        private IWebElement searchButton => Driver.FindElement(By.CssSelector("#main-search-form > button > i")); 
        private IWebElement searchResult => Driver.FindElement(By.CssSelector("#homepage > div.container > div > div.col-10.products-holder-wrapper > div:nth-child(1) > div > div > p:nth-child(3) > strong:nth-child(2)")); 
        private string expectedSearchResult => "karas"; 


        public KnygosLtMainPage(IWebDriver webdriver) : base(webdriver)
        {
        }

        public KnygosLtMainPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public KnygosLtMainPage AcceptCookies()
        {
            allowCookieButton.Click();
            return this;
        }

        public KnygosLtMainPage EnterSubscriptionEmail(string email)
        {
            subscriptionEmailField.SendKeys(email);
            return this;
        }
        public KnygosLtMainPage SelectBothSubsriptionCheckBoxes()
        {
            subscriptionFirstCheckBox.Click();
            subscriptionSecondCheckBox.Click();
            return this;
        }


        public KnygosLtMainPage ClickSubscriptionButton()
        {
            subscriptionButton.Click();
            return this;
        }

        public KnygosLtMainPage VerifySubsciption()
        {
            Thread.Sleep(3000);
            Assert.AreEqual(expectedsubscriptionResult, subscriptionResult.Text);
            return this;
        }
        public KnygosLtMainPage ProductSearchField(string product)
        {
            searchField.SendKeys(product);
            return this;
        }
            
        public KnygosLtMainPage ClickSearchButton()
        {
            searchButton.Click();
            return this;
        }

        public KnygosLtMainPage VerifyProductSearch()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(expectedSearchResult, searchResult.Text);
            return this;
        }



    }
}
