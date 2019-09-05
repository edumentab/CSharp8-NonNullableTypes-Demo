using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_warnings_demo
{
    /// <summary>
    /// CS8618: Non-nullable field 'XXX' is uninitialized.
    /// CS8618: Non-nullable property 'XXX' is uninitialized.
    /// </summary>
    class FieldsAndProperties
    {
        public virtual string FirstName { get; set; } //CS8618

        public string LastName; //CS8618
    }
}
