﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbim.ExpressParser.SDAI
{
    public class DerivedAttribute: Attribute, ExplicitOrDerived
    {
        public BaseType Domain { get; set; }
        public ExplicitOrDerived Redeclaring { get; set; }

    }
}
