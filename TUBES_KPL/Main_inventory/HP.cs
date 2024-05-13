using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_inventory
{
    internal class HP
    {
        public string NamaHP { get; set; }

        public int KodeHP { get; set; }

        public int JumlahHP { get; set; }

        public int HargaHP { get; set; }

        public HP(string NamaHP, int KodeHP, int JumlahHP, int HargaHP)
        {
            this.NamaHP = NamaHP;
            this.KodeHP = KodeHP;
            this.JumlahHP = JumlahHP;
            this.HargaHP = HargaHP;
        }
    }
}

