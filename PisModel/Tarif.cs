using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class Tarif
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string NameTarif { get; set; }

        [DataMember]
        public double UnitPrice { get; set; }

        [ForeignKey("TarifId")]
        public virtual List<СonsumedService> СonsumedServices { get; set; }
    }
}
