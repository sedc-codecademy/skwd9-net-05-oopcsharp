using System;

namespace SEDC.OopCSharp.Exceptions.Demo
{
    public class MyException : Exception
    {
        public MyException(string message,int httpRequestCode) : base(message)
        {
            this.Message = message + " " + httpRequestCode;
            this.HttpStatusCode = httpRequestCode;
        }
        public string Message { get; set; }
        public int HttpStatusCode { get; set; }
    }
}
