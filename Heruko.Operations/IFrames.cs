﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heruko.Operations
{
    public interface IFrames
    {
      
        void VerifyNestedFramesRouting();
        void VerifyiFrameRouting();
        void VerifyIframeIsTakingInputOrNot();
        void VerifyWhetherNestedFrameworkHavingMoreThanOneFramework();

    }
}
