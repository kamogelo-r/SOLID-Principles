using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.Liskov_Substitution.Old
{
    /// <summary>
    /// a child class should be substitutable for its parent class
    /// Enquiry is NOT a type of Customer
    /// it needs Add() and not GetDiscounts()
    /// the child class therefore does not easily implement/replace the parent class
    /// </summary>
    public class Enquiry:Customers
    {
        public Enquiry(){ }
        public override double GetDiscounts(double totalSales)
        {
            return base.GetDiscounts(totalSales);
        }
        public override void Add(Customers customer)
        {
            throw new Exception("Not Allowed"); 
        }
    }
}
