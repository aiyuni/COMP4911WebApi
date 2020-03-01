using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Helpers
{
    public class ErrorObject
    {
        public int ErrorCode { get; set; }
        public string ErrorMsg { get; set; }

        public ErrorObject(int code, string msg)
        {
            this.ErrorCode = code;
            this.ErrorMsg = msg;
        }
    }
}
