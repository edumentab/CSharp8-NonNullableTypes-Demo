using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_warnings_demo
{
    /// <summary>
    /// Warning	CS8621	Nullability of reference types in return type of 'XXX' doesn't match the target delegate 'YYY'.	                                                          
    /// Warning	CS8622	Nullability of reference types in type of parameter 'XXX' of 'YYY' doesn't match the target delegate 'ZZZ'.	
    /// </summary>
    public class Delegates
    {
        public void DelegateSample()
        {
            Func<string[], string[]> a = Method2; // CS8621
            Func<string[]?, string[]?> v = Method1; // CS8622
        }

        public string[] Method1(string?[] input)
        {
            return null!;
        }
        public string[]? Method2(string[] input)
        {
            return null!;
        }
    }
}
