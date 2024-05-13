using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Main_inventory
{
    internal class Distribusi
    {
        public string Nama { get; set; }    
        
        public Distribusi()
        {
        }

        
        public Distribusi(string nama)
        {
            this.Nama = nama; 
        }
    }
}
