using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace Client
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        void Say(string input);
    }
}
