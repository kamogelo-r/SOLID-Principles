using SOLIDprinciples.Interface_Segregation.Old;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.Interface_Segregation.New
{
    class CustomerWithRead : IDatabase, IDatabaseV1
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }

    //IDatabase i = new Customer(); //100 happy clients not touched
    //i.Add();

    //IDatabaseV1 v1 = new CustomerWithRead(); // clients that want new implementation
    //iv1.Read();
}
