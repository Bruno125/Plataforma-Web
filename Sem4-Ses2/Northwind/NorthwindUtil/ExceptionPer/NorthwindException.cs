using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindUtil.ExceptionPer
{
    [Serializable]
    public class NorthwindException : Exception
    {
        public NorthwindException() : base()
        {
            
        }

        public NorthwindException(string message) : base(message)
        {

        }

        public NorthwindException(string message, Exception exception) : base(message,exception)
        {
        }
    }
}
