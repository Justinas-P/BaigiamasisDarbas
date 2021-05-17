using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnygosLt.Test
{
    public class KnygosLtMainTest : BaseTest
    {
        [Test]
        public static void SubscriptionTest()
        {
            page.NavigateToPage()
                .AcceptCookies()
                .EnterSubscriptionEmail("aaa@aaa.lt")
                .SelectBothSubsriptionCheckBoxes()
                .ClickSubscriptionButton();
                
        }
        [Test]
        public static void SearchFieldTest()
        {
            page.NavigateToPage()
                .AcceptCookies()
                .ProductSearchField("karas")
                .ClickSearchButton()
                .VerifyProductSearch();

                
        }
    }
}

                

