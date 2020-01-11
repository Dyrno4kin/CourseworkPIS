using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BindingModels
{
    public class PrivilegeBindingModel
    {
        public int Id { get; set; }
        public string NamePrivilege { set; get; }
        public string TypePrivilege { set; get; }
        public double Multiplier { set; get; }
    }
}
