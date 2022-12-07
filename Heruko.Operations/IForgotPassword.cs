using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heruko.Operations
{
    public interface IForgotPassword
    {
        void verifyHeading();
        void verifyLabel();
        void verifyInput();
        void verifyRetrievePasswordButton();

    }
}
