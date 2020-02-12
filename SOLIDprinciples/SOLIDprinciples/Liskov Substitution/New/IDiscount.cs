using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.Liskov_Substitution.New
{
    interface IDiscount
    {
        double GetDiscount(double totalSales);
    }
}
