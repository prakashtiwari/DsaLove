﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandles.Handlers
{
    public class CustomException : Exception
    {
        public CustomException(string message, Exception innerex):base(message,innerex)
        { 
         
        }
    }
}
