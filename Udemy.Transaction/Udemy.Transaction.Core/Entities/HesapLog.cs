using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Transaction.Core.Entities
{
    public class Hesaplog
    {
        public int ID { get; set; }

        public int GonderenHesap { get; set; }

        public int AlanHesap { get; set; }

        public decimal Tutar { get; set; }

        public DateTime OlusturmaTarihi { get; set; }
    }
}
