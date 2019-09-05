using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_warnings_demo
{
    /// <summary>
    /// Various warnings
    /// CS8632: The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
    /// </summary>
    class OtherWarnings
    {
        public void Do()
        {
            #nullable disable
            string? hello = null;  //CS8632
        }
    }
}
