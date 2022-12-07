using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuApp.Operations
{
    public interface IDragAndDrop
    {
        void verifyHeader();
        void verifyDragA();
        void verifyDragB();
    }
}
