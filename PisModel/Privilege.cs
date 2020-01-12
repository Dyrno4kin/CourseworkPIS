using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Model
{   [DataContract]
    public class Privilege
    {
        [DataMember]
        public int Id { get; set;}
        [DataMember]
        public string NamePrivilege { set; get; }
        [DataMember]
        public string TypePrivilege { set; get; }
        [DataMember]
        public double Multiplier { set; get; }

        [ForeignKey("PrivilegeId")]
        public virtual List<PeoplePrivilege> PeoplePrivileges { get; set; }
    }
}
