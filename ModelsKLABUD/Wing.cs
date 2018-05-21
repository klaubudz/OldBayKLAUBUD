using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelsKLABUD
{
    [DataContract]
    public class Wing
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Power { get; set; }

        [DataMember]
        public int Shield { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
