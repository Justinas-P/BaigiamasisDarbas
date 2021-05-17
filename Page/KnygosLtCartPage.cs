using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnygosLt.Page
{
    public class KnygosLtCartPage : BasePage
    {
        private const string PageAddress = "https://www.knygos.lt/";

        private IWebElement allowCookieButton => Driver.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-custom.cc-bottom > div.cc-compliance.cc-highlight > a.cc-btn.cc-allow"));
        private IWebElement loginButton => Driver.FindElement(By.CssSelector("#hr-1 > div.user-menu > div.user-menu-item.profile-menu-item > a > span.text"));

        private IWebElement userLoginEmailField => Driver.FindElement(By.Id("emailInput"));
        private IWebElement userLoginPasswordField => Driver.FindElement(By.Id("passwordInput"));
        private IWebElement prisijungtiButton => Driver.FindElement(By.CssSelector("body > main > div > div:nth-child(2) > div.col-lg-6.mb-3.mb-lg-0 > div > div > form > div.row > div:nth-child(1) > input"));
        private IWebElement cartButton => Driver.FindElement(By.Id("cart"));
        private IWebElement issirinkitePrekiuButton => Driver.FindElement(By.CssSelector("body > main > div > div.row.flex-cart-row > div > div > div > p > a"));
        private IWebElement rekomenduojamosKnygosButton => Driver.FindElement(By.CssSelector("#rekomenduojamos-knygos > div > a"));
        private IWebElement iKrepseliButton => Driver.FindElement(By.Id("add_to_cart_single_add_to_cart_"));
        private IWebElement perziuretiKrepseliButton => Driver.FindElement(By.CssSelector("#post-add-to-cart-modal > div > div > div.modal-footer.border-top-0 > a.btn.btn-primary"));
        private IWebElement cartMessage => Driver.FindElement(By.CssSelector("#cart-items > div.row.no-gutters.border-bottom.py-2.k-cart-item > div.col-md-7.col-xs-12.d-flex.align-items-center.mb-2.mb-md-0 > div > div.mb-1.font-weight-bold > a"));
        private string expectedCartMessage => "PETRO IMPERATORĖ II: antroji dilogijos knyga";

        public KnygosLtCartPage(IWebDriver webdriver) : base(webdriver)
        {
        }
        public KnygosLtCartPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
        public KnygosLtCartPage AcceptCookies()
        {
            allowCookieButton.Click();
            return this;
        }
        public KnygosLtCartPage ClickLoginButton()
        {
            loginButton.Click();
            return this;
        }
        public KnygosLtCartPage UserLogin(string mail, string password)
        {
            userLoginEmailField.SendKeys(mail);
            userLoginPasswordField.SendKeys(password);
            return this;
        }
        public KnygosLtCartPage ClickPrisijungtiButton()
        {
            prisijungtiButton.Click();
            return this;
        }
        public KnygosLtCartPage ClickCartButton()
        {
            cartButton.Click();
            return this;
        }
        public KnygosLtCartPage ClickIssirinkitePrekiuButton()
        {
            issirinkitePrekiuButton.Click();
            return this;
        }
        public KnygosLtCartPage ClickRekomenduojamosKnygosButton()
        {
            rekomenduojamosKnygosButton.Click();
            return this;
        }
        public KnygosLtCartPage ClickIKrepseliButton()
        {
            iKrepseliButton.Click();
            return this;
        }
        public KnygosLtCartPage VerifyCartMessage()
        {
            Assert.AreEqual(expectedCartMessage, cartMessage.Text);
            return this;
        }
        public KnygosLtCartPage ClickPerziuretiKrepseliButton()
        {
            perziuretiKrepseliButton.Click();
            return this;
        }

    }

}
