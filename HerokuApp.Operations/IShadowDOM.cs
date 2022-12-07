using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuApp.Operations
{
    public interface IShadowDOM
    {
        void verifyHeader();
        void verifyParagraph1();
        void verifyParagraph2();
    }
}
