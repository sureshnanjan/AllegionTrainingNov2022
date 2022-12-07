using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuApp.Operations
{
    public interface IHover
    {
        void verifyHeader();
        void verifyParagraph();
        void verifyUserImage1();
        void verifyUserImage2();
        void verifyUserImage3();
        void verifyUser1();
        void verifyUser2(); 
        void verifyUser3();
        void verifyViewProfile();
    }
}
