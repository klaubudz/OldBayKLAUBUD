using ModelsKLABUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingRepositoryKLABUD
{
    public interface IWingDB
    {
        Wing GetWing(string name);
        string CreateWing(Wing wing);
        List<Wing> GetAllWings();
    }
}
