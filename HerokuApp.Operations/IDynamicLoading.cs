using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuApp.Operations;

namespace HerokuApp.Operations
{
    public interface IDynamicLoading
    {
        void verifyHeader();

        void verifyParagraph();
        void verifyLink1(); //Element on page that is hidden
        void verifyHeader2();
        void verifySubHeader();
        void verifyButton();
        void verifyDynamicLoading();
        void verifyFooter();

        void verifyLink2(); //Element rendered after the fact
        void verifyHeader3();
        void verifySubHeader3();
        void verifyButton3();
        void verifyDynamicLoading2();
        void verifyFooter3();

        void verifyFooter4(); //Dynamic loading main page

        


    }
}
