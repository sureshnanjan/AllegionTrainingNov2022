using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heruko.Operations
{
    public interface IChallengingDom
    {
        void verifyHeading();
        void verifyParagraph();
        void verifyLinkButton1();

        void verifyLinkButton2();
        void verifyLinkButton3();
        void editRow();
        void deleteRow();
        void verifyAnswer();

    }
}
