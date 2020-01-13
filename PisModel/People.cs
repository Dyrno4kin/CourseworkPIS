using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class People
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public bool Owner { get; set; }
        [DataMember]
        public int ApartmentId { get; set; }
        [DataMember]
        public DateTime Date { get; set; }

        public virtual Apartment Apartment { get; set; }

        [ForeignKey("PeopleId")]
        public virtual List<PeoplePrivilege> PeoplePrivileges { get; set; }
    }
}
