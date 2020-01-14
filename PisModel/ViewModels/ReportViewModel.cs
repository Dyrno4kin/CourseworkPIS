using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class ReportViewModel
    {
        public string Adres { get; set; }
        public int NaGas { get; set; }
        public int NaVodu { get; set; }
        public int NaElectr { get; set; }
        public int NaObchedomovie { get; set; }

    }
}
