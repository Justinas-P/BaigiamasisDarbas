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
    public class KnygosLtLoginPage : BasePage
    {
        private const string PageAddress = "https://www.knygos.lt/cart/login";

        private IWebElement registrationButton => Driver.FindElement(By.CssSelector("body > main > div > div:nth-child(2) > div.col-lg-6.d-flex.align-self-stretch > div > div > div > div:nth-child(1) > a"));
        private IWebElement allowCookieButton => Driver.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-custom.cc-bottom > div.cc-compliance.cc-highlight > a.cc-btn.cc-allow"));
        private IWebElement vardasField => Driver.FindElement(By.Id("registration_user_firstname"));
        private IWebElement pavardeField => Driver.FindElement(By.Id("registration_user_lastname"));
        private IWebElement telefonasField => Driver.FindElement(By.Id("registration_user_phone"));
        private IWebElement elpastasField => Driver.FindElement(By.Id("registration_user_email"));
        private IWebElement slaptazodisField => Driver.FindElement(By.Id("registration_password_first"));
        private IWebElement pakartotiSlaptazodiField => Driver.FindElement(By.Id("registration_password_second"));
        private IWebElement privatumoPolitikaCheckBox => Driver.FindElement(By.Id("registration_agree_to_tos"));
        private IWebElement registrationSubmitButton => Driver.FindElement(By.Id("registration_submit"));
        public string expectedMailInUseMessage => "Toks el. pašto adresas jau egzistuoja";
        private IWebElement emailInUseMessage => Driver.FindElement(By.CssSelector("#registration_user > div:nth-child(5) > label > span > span > span.form-error-message"));
        private IWebElement userLoginEmailField => Driver.FindElement(By.Id("emailInput"));
        private IWebElement userLoginPasswordField => Driver.FindElement(By.Id("passwordInput"));
        private IWebElement prisijungtiButton => Driver.FindElement(By.CssSelector("body > main > div > div:nth-child(2) > div.col-lg-6.mb-3.mb-lg-0 > div > div > form > div.row > div:nth-child(1) > input"));
        public string expectedUserLoginMessage => "Mano paskyra";
        private IWebElement userLoginMessage => Driver.FindElement(By.CssSelector("#hr-1 > div.user-menu > div.user-menu-item.auth-profile-menu-item"));


        public KnygosLtLoginPage(IWebDriver webdriver) : base(webdriver)
        {
        }

        public KnygosLtLoginPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
        public KnygosLtLoginPage AcceptCookies()
        {
            allowCookieButton.Click();
            return this;
        }

        public KnygosLtLoginPage ClickRegistrationButton()
        {
            registrationButton.Click();
            return this;
        }
        public KnygosLtLoginPage EnterUserInformation(string vardas, string pavarde, string telefonas, string pastas, string pass1, string pass2)
        {
            vardasField.SendKeys(vardas);
            pavardeField.SendKeys(pavarde);
            telefonasField.SendKeys(telefonas);
            elpastasField.SendKeys(pastas);
            slaptazodisField.SendKeys(pass1);
            pakartotiSlaptazodiField.SendKeys(pass2);


            return this;
        }
        public KnygosLtLoginPage ClickPrivatumoPolitikaCheckBox()
        {
            privatumoPolitikaCheckBox.Click();
            return this;
        }
        public KnygosLtLoginPage ClickRegistrationSubmitButton()
        {
            registrationSubmitButton.Click();
            return this;
        }
        public KnygosLtLoginPage CheckUserMail()
        {
            Assert.AreEqual(expectedMailInUseMessage, emailInUseMessage.Text);
            return this;
        }

        public KnygosLtLoginPage UserLogin(string mail, string password)
        {
            userLoginEmailField.SendKeys(mail);
            userLoginPasswordField.SendKeys(password);
            return this;
        }
        public KnygosLtLoginPage ClickPrisijungtiButton()
        {
            prisijungtiButton.Click();
            return this;
        }
        public KnygosLtLoginPage VerifyUserLogin()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(expectedUserLoginMessage, userLoginMessage.Text);
            return this;
        }

    }



}
