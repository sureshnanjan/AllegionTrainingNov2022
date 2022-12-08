using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroKuApp.Operations
{
    public interface IJQueryUIMenus
    {
        string VerifyJQueryUIMenusHeading();

        void VerifyJQueryUIMenusEnabledDownloads();

        void VerifyJQueryUIMenusEnabledBackToJQueryUI();

        void VerifyJQueryUIMenusLink();


    }
}
