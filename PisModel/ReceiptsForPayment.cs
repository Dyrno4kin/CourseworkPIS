using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class ReceiptsForPayment
    {

        [DataMember]
        [Key]
        [ForeignKey("Apartment")]
        public int Id { get; set; }

        [DataMember]
        public double Sum { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        public virtual Apartment Apartment { get; set; }
    }
}
