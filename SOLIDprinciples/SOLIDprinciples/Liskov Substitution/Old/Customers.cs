using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.Liskov_Substitution.Old
{
    public class Customers
    {
        public Customers(){ }

        public virtual double GetDiscounts(double totalSales)
        {
            return totalSales;
        }

        public virtual void Add(Customers customer)
        {
           
        }
    }
}
