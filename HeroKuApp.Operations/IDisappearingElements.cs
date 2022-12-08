using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroKuApp.Operations
{
    public interface IDisappearingElements
    {
        string VerifyDisappearingElementsPageHeading();

        string VerifyDisappearingElementsPageDescription();

        void VerifyDisappearingElementsPageList();

        void VerifyDisappearingElementsPageListLinkWorking();

        void VerifyPageReloadAndElementDisappearance(); 
    }
}
