using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Privilege
    {
        public int Id { get; set;}
        public string NamePrivilege { set; get; }
        public string TypePrivilege { set; get; }
        public double Multiplier { set; get; }

        [ForeignKey("PrivilegeId")]
        public virtual List<PeoplePrivilege> PeoplePrivileges { get; set; }
    }
}
