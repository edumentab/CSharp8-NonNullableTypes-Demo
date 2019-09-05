using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_warnings_demo
{
    /// <summary>
    /// Warning	CS8597	Thrown value may be null.	  
    /// </summary>
    class Exceptions
    {
        public void CS8597()
        {
            throw null;   //CS8597
        }

    }
}
