using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuApp.Operations
{
    public interface ILargeAndDeepDOM
    {
        void verifyHeader();
        void verifyParagraph();
        void verifyNoSiblingHeader();
        void verifySiblingHeader();
        void verifySiblings();
        void verifyTable();

    }
}
