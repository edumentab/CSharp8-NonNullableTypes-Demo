using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_warnings_demo
{
    /// <summary>
    /// //CS8609: Nullability of reference types in return type doesn't match overridden member
    /// //CS8610: Nullability of reference types in type of parameter 'XXX' doesn't match overridden member.
    /// </summary>
    public class User
    {
        public virtual string FirstName { get; set; } = "";

        public virtual System.Action<string> Hello(System.Action<string> x)
        {
            return null!;
        }

    
    }

    public class SubUser : User
    {
        public override string? FirstName { get; set; } //CS8609

        public override System.Action<string> Hello(System.Action<string?> x) //CS8610
        {
            return null!;
        }
    }

    public abstract class A
    {
        public abstract List<string> UserNames( List<string> data);
        public abstract List<string> FirstName { get; set; }
    }  
    public abstract class B : A
    {
        public override List<string?> FirstName { get; set; } //CS8609

        public override List<string> UserNames( List<string> data)
        {   
            return FirstName;
        }

    }
}
