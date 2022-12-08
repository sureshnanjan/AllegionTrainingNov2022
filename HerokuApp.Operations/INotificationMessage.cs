using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuApp.Operations;

namespace HerokuApp.Operations
{
    public interface INotificationMessage
    {
        void verifyFlashMessage();

        void verifyHeader();

        void verifyParagraph();
        void verifyClickHere();
        void verifyFlashMessage2();
        void verifyFooter();

    }
}
