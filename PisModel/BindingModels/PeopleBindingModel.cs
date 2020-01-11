using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BindingModels
{
    public class PeopleBindingModel
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public bool Owner { get; set; }

        public int ApartmentId { get; set; }

        public virtual List<PeoplePrivilegeBindingModel> PeoplePrivileges { get; set; }
    }
}
