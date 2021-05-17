using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnygosLt.Test
{
    public class KnygosLtLoginTest : BaseTest
    {
        [Test]
        public static void RegistrationTest()
        {
            loginPage.NavigateToPage()
                .AcceptCookies()
                .ClickRegistrationButton()
                .EnterUserInformation("Vardenis", "Pavardenis", "861234567", "vcstest0@gmail.com", "password", "password")
                .ClickPrivatumoPolitikaCheckBox()
                .ClickRegistrationSubmitButton()
                .CheckUserMail();
           
        }
        [Test]
        public static void UserLoginTest()
        {
            loginPage.NavigateToPage()
                .AcceptCookies()
                .UserLogin("vcstest0@gmail.com", "password")
                .ClickPrisijungtiButton()
                .VerifyUserLogin();

        }
    }
}
