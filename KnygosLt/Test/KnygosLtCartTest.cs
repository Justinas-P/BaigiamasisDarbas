using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnygosLt.Test
{
    public class KnygosLtCartTest : BaseTest
    {
        [Test]
        public static void AddProductToCartTest()
        {
            cartPage.NavigateToPage()
                .AcceptCookies()
                .ClickLoginButton()
                .UserLogin("vcstest0@gmail.com", "password")
                .ClickPrisijungtiButton()
                .ClickCartButton()
                .ClickIssirinkitePrekiuButton()
                .ClickRekomenduojamosKnygosButton()
                .ClickIKrepseliButton()
                .ClickPerziuretiKrepseliButton()
                .VerifyCartMessage();


        }
    }
}
