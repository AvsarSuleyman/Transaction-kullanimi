using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Transaction.Core.Entities
{
    public class Hesap
    {
        public int ID { get; set; }

        public string HesapNumarasi { get; set; }

        public string HesapAdi { get; set; }

        public decimal Tutar { get; set; }

    }
}
