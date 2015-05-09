using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindUtil.ExceptionPer
{
    [Serializable]
    public class NothwindException : Exception
    {
        public NothwindException() 
            : base()
        { }
        public NothwindException(string message) 
            : base(message)
        { }
        public NothwindException(string message, Exception exception)
            : base(message , exception)
        { }
    }
}
