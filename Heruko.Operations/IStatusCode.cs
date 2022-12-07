using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heruko.Operations
{
    public interface IStatusCode
    {
        void verifyParagraph();
        void verify200IsRedirecting();
        void verify301IsRedirecting();
        void verify404IsRedirecting();
        void verify500IsRedirecting();
        void verifyWhetherGoHereLinkIsRedirectingOrNot();

    }
}
