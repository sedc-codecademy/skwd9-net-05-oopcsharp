using System;
using System.Collections.Generic;
using System.Text;

namespace SpecificExceptions.CustomExceptions
{
    public class ViktorException : Exception
    {
        public string CustomErrorMessage { get; set; }
        public string  Service { get; set; }

        public ViktorException(string ex, string service)
        {
            CustomErrorMessage = ex;
            Service = service;
        }
    }
}
