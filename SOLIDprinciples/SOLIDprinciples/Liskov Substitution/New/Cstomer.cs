using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.Liskov_Substitution.New
{
    /// <summary>
    /// Implementing an interface describes a can-do relationship.
    /// Any additions to the interface would break existing types implementing the interface
    /// </summary>
    public class Cstomer : IDatabase, IDiscount
    {
        public void Add()
        {
            try
            {
                // TODO: logic for inserting to DB
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public double GetDiscount(double totalSales)
        {
            return totalSales;
        }
    }
}
