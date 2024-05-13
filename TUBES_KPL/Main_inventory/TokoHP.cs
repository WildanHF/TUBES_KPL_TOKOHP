using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_inventory
{
    internal class TokoHP
    {
       
   
            private List<HP> DataHP = new List<HP>
             {
                new HP("Samsung", 1, 5 ,100000),
                new HP("Iphone",2 ,  5,200000),
                new HP("Xiaomi",3, 4 ,300000),

            };

            public void cariHP(string NamaHP)
            {

                for (int i = 0; i < DataHP.Count; i++)
                {
                    if (NamaHP == DataHP[i].NamaHP)
                    {
                        Console.WriteLine("Nama Barang: " + DataHP[i].NamaHP);
                        Console.WriteLine("Kode Barang" + DataHP[i].KodeHP);
                        Console.WriteLine("Jumlah Barang: " + DataHP[i].JumlahHP);
                        Console.WriteLine("Harga Barang: " + DataHP[i].HargaHP);

                    }
                }
            }
            public int returnIndex(string NamaHP)
            {
                int index = -1;

                for (int i = 0; i < DataHP.Count; i++)
                {
                    if (NamaHP == DataHP[i].NamaHP)
                    {
                        return index = i;
                        break;
                    }
                }

                return index;
            }

        internal void cariHp(string v)
        {
            throw new NotImplementedException();
        }
    }
}


