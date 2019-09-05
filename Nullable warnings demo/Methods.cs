using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_warnings_demo
{
    /// <summary>
    /// CS8603: Possible null reference return.
    /// CS8604:	Possible null reference argument for parameter 'XXXX' in 'YYYY'.
    /// CS8620: Argument of type 'XXX' cannot be used for parameter 'input' of type 'YYY' in 'XXX' due to differences in the nullability of reference types.
    /// CS8624: Argument cannot be used as an output for parameter due to differences in the nullability of reference types
    /// </summary>
    class Methods
    {
        public void Start()
        {
            Func<string?> data = () => "C#!";
            GetMoreStuffDone(data); //CS8620  

            TestingOut(out string[] param1); //CS8624

            string? input = null;
            TestMethod(input); //CS8604
        }

        public void TestingOut(out string?[] param1)
        {
            param1 = null!;
        }

        public void GetMoreStuffDone(Func<string> input)
        {
        }

        public string TestMethod(string input)
        {
                return null;    //CS8603
        }

    }
}
