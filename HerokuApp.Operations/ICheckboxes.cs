using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuApp.Operations
{
    public interface ICheckboxes
    {
        void verifyHeader();
        void verifyCheckbox1();
        void verifyCheckbox2();
    }
}
