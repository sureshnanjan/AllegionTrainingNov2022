using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroKuApp.Operations
{
    public interface IJavaScriptAlert
    {
        void ClickOnJSAlertItem(int item);
        string GetJavaScriptText();
        void AcceptJavaScriptAlert();

    }
}
