using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class People
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public bool Owner { get; set; }

        public int ApartmentId { get; set; }
        public virtual Apartment Apartment { get; set; }

        [ForeignKey("PeopleId")]
        public virtual List<PeoplePrivilege> PeoplePrivileges { get; set; }
    }
}
