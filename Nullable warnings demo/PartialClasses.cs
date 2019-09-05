using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_warnings_demo
{
    /// <summary>
    /// warning CS8611: Nullability of reference types in type of parameter 's' doesn't match partial method declaration.
    /// </summary>
    public partial class PartialUser
    {
        partial void OnSomethingHappened(ref string s);
    }

    public partial class PartialUser
    {
        partial void OnSomethingHappened(ref String? s) //CS8611
        {
            Console.WriteLine("Something happened: {0}", s);
        }
    }
}
