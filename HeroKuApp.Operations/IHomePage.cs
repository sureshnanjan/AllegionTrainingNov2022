using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroKuApp.Operations
{
    public interface IHomePage
    {

        string VerifyHomePageHeading();

        string VerifyHomePageDescription();

        void RouteTopage(string pageName);

        void VerifyImageIsVisible();

        void VerifyImageLinkIsWorking();

        void VerifyFooter();

        void VerifyFooterLinkIsWorking();
    }
}
