﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint01
{
    interface IisTransportWithTempomat : IisTransport
    {
        double WayRange { get; set; }
    }
}
