using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class PeopleViewModel
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public bool Owner { get; set; }
        public int ApartmentId { get; set; }

        public string NumberHouse { get; set; }
        public int NumberApartment { get; set; }

        public List<PeoplePrivilegeViewModel> PeoplePrivileges { get; set; }

    }
}
