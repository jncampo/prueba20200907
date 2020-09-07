using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sevicio
{
    [DataContract]
    public class PersonM
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Telefono { get; set; }
    }
}
