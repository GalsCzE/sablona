﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sablona.Interface
{
    interface IParse
    {
        Task<T> ParseString<T>(string response);
    }
}
