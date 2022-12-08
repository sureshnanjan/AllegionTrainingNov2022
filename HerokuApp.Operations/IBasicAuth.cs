using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuApp.Operations;

namespace HerokuApp.Operations
{
    public interface IBasicAuth
    {
        //signin page
        void verifyUsername();
        void verifyPassword();
        void verifyCancel();

        //after typing credentials
        void verifyHeader();
        void verifyParagraph();
        void verifyFooter();


    }
}
