using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable_warnings_demo
{
    /// <summary>
    /// CS8613: Nullability of reference types in return type of '{0}' doesn't match implicitly implemented member '{1}'.
    /// CS8614: Nullability of reference types in type of parameter '{0}' of '{1}' doesn't match implicitly implemented member '{2}'.
    /// CS8616: Nullability of reference types in return type doesn't match implemented member.
    /// CS8617: Non-nullable field is uninitialized. Consider declaring as nullable.
    /// </summary>
    public interface IUser
    {
        string CalculateSalary(string id);
        void CalculateSalaryTax(System.Action<string> x);

        List<string> GetTaxRates();
        List<string> SetGetTaxRates(List<string> rates);
    }

    public class TaxCalculator : IUser
    {
        public string? CalculateSalary(string? Id) => null; //CS8613

        public void CalculateSalaryTax(System.Action<string?>? id) => Console.WriteLine("Hello!"); //CS8614

        //this only occurs for explicit interface implementations.
        List<string?> IUser.GetTaxRates() => null!; //CS8616
        List<string> IUser.SetGetTaxRates(List<string?> rates) => null!; //CS8617
    }
}
