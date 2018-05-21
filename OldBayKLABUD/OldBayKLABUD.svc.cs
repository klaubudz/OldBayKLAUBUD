using ModelsKLABUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WingRepositoryKLABUD;

namespace OldBayKLABUD
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class OldBayKLABUD : IOldBayKLABUD
    {
        private readonly WingDB _db = new WingDB();

        public string CreateWing(Wing wing) => _db.CreateWing(wing);
        public Wing GetWing(string name) => _db.GetWing(name);
        public List<Wing> GetAllWings() => _db.GetAllWings();
    }
}
