using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.Liskov_Substitution.New
{
    public class Enquiryy : IDiscount
    {
        public double GetDiscount(double totalSales)
        {
            throw new NotImplementedException();
        }
    }
}
