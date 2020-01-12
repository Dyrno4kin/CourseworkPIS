using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Model
{   [DataContract]
    public class Apartment
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NumberHouse { get; set; }
        [DataMember]
        public int NumberApartment { get; set; }
        [DataMember]
        public double ApartmentSize { get; set; }

        [ForeignKey("ApartmentId")]
        public virtual List<People> Peoples{ get; set; }
    }
}
