using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.Interface_Segregation.Old
{
    /// <summary>
    /// child classes should not be forced to use interfaces that are irrelevant to it
    /// the child would now have to use both methods, even though it only needs one
    /// </summary>
    interface IDatabase
    {
        void Add();
        void Read();
    }
}
