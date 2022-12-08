﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heruko.Operations
{
    public interface IHomePage
    {
        string verifyHeading();
        void verifySubHeading();
        void verifyNumberOfFeatures();
        void verifyFooter();

    }
}