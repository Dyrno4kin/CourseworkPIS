using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BindingModels
{
    public class PeoplePrivilegeBindingModel
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public int PrivilegeId { get; set; }
    }
}
