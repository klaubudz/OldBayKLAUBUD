using ModelsKLABUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OldBayKLABUD
{
    [ServiceContract]
    public interface IOldBayKLABUD
    {
        [OperationContract]
        Wing GetWing(string name);

        [OperationContract]
        string CreateWing(Wing wing);

        [OperationContract]
        List<Wing> GetAllWings();
    }
}
