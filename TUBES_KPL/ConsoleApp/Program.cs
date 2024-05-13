using Table1;
using Class1; 

internal class Program
{
    static void Main(string[] args)
    {
        
        Inventaris inventarisHP = new Inventaris();

        inventarisHP.TambahStokBarang("Samsung S24 Ultra", 01, 10, 21500000, "Samsung");
        inventarisHP.TambahStokBarang("Samsung S23 Ultra", 02, 25, 19500000, "Samsung");
        inventarisHP.TambahStokBarang("IPhone 15 Pro Max", 03, 15, 23500000, "IPhone");

        inventarisHP.TampilkanInventaris();

        inventarisHP.HapusBarang("IPhone 15 Pro Max", 03, 15, 23500000, "IPhone");
        Console.WriteLine("============= Barang berhasil dihapus =================");
        Console.WriteLine("");

        inventarisHP.TampilkanInventaris();

        TableDriven tableDriven = new TableDriven();
        tableDriven.getDisplayInfo();
    }
}