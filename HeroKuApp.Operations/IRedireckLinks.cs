using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroKuApp.Operations
{
    public interface IRedireckLinks
    {
        string VerifyRedirectLinksPageHeading();

        string VerifyRedirectLinksLinkPageDescripting();

        void VerifyRedirectLinksRoutingWorks();

    }
}
