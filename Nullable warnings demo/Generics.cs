using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Nullable_warnings_demo
{
    /// <summary>
    /// CS8631: The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. Nullability of type argument '{3}' doesn't match constraint type '{1}'.</value>
    /// CS8634: The type cannot be used as type parameter in the generic type or method. Nullability of type argument doesn't match 'class' constraint.
    /// </summary>
    class Generics
    {
        public void DoStuff()
        {
            var x = new Bar<Foo?>();  //CS8631
        }
    }

    public class Foo
    {
    }

    public class Bar<T> where T : Foo 
    {
    }

    //CS8634----------------------------

    public class Cs8634
    {
        public void Start()
        {
            var fooz = new Bar8634<ILogger?>(); //CS8634
        }
    }

    public interface ILogger
    {
        void Log();
    }

    public class Bar8634<T> where T : class
    {
    }


}
