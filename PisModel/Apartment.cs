using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Apartment
    { 
        public int Id { get; set; }
        public string NumberHouse { get; set; }
        public int NumberApartment { get; set; }
        public double ApartmentSize { get; set; }

        [ForeignKey("ApartmentId")]
        public virtual List<People> Peoples{ get; set; }
    }
}
