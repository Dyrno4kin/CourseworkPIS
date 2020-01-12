using System.Runtime.Serialization;

namespace Model
{   [DataContract]
    public class PeoplePrivilege
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int PeopleId { get; set; }
        [DataMember]
        public int PrivilegeId { get; set; }
        public virtual People People { get; set; }
        public virtual Privilege Privilege { get; set; }
    }
}
