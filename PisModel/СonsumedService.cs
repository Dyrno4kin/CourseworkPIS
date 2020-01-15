using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class СonsumedService
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string TypeService { get; set; }

        [DataMember]
        public int Count { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public int ApartmentId { get; set; }

        [DataMember]
        public int TarifId { get; set; }

        public virtual Apartment Apartment { get; set; }

        public virtual Tarif Tarif { get; set; }

    }
}
