﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentC_.HomeWork6
{
    internal class ParseException : Exception
    {
        public ParseException(string? message) : base(message)
        {
           
        }
    }
}
