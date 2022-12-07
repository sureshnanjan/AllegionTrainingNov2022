using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heruko.Operations
{
    internal interface IKeyPresses
    {
        void verifyParagraphCheck();
        void verifyWhetherAlphabetsIsDetectingOrNot();
        void verifyWhetherNumericIsDetectingOrNot();
        void verifyWhetherSpecialSymbolIsDetectingOrNot();

        void verifyWhetherFunctionKeyIsDetectingOrNot();
        void verifyWhetherWindowsIsDetectingOrNot();
        void verifyWhetherArrowKeysIsDetectingOrNot();
        void verifyWhetherDataAreEnteredAreNot();

    }
}
