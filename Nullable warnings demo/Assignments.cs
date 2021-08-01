using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_warnings_demo
{
    /// <summary>
    /// CS8600 Converting null literal or possible null value to non-nullable type.
    /// CS8601 Possible null reference assignment.
    /// CS8602 Dereference of a possibly null reference.
    /// CS8605 Unboxing a possibly null value.
    /// CS8606 Possible null reference assignment to iteration variable
    /// CS8619 Nullability of reference types in value of type 'XXX' doesn't match target type 'YYY'
    /// CS8625 Cannot convert null literal to non-nullable reference type.
    /// CS8629 Nullable value type may be null.
    /// </summary>
    class Assignments
    {
        public void Cs8600()
        {
            string? data = null;
            string tmp = data; //CS8600
        }

        private string FirstName = "";
        public void Cs8601()
        {
            string? data = null;
            FirstName = data; //CS8601
        }

        public void Cs8602()
        {
            string? data = null;
            int len = data.Length; //CS8602
        }

        public void Cs8605(string input)
        {
            bool b1 = true;
            bool b2 = (bool)(object?)b1; //CS8605
        }

        public void Cs8606(string input)
        {
            var list = new List<Object?>();
            foreach (object item in list)    //CS8606
            {
                Console.WriteLine(item);
            }
        }

        public void Cs8619()
        {
            string[] data = null!;
            string[] result = data as string?[];  //CS8619
        }

        public void Cs8625()
        {
            List<SubUser> users = new List<SubUser>();
            users.Add(null); //CS8625
        }

        public void Cs8629()
        {
            char? tmp = null;
            char d = (char)tmp; //CS8629
        }


    }
}
