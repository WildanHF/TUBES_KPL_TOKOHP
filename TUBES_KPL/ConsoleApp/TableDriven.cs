namespace Table1
{
    public class TableDriven
    {
        public enum MerkHP
        {
            Samsung,
            OPPO,
            Realme,
            IPhone,
            Xiaomi
        }

        public string GetNamaMerkHP( MerkHP inputnama)
        {
            string[] outputNama = { "Samsung S24 Ultra", "Samsung S23 Ultra", "Samsung Galaxy Flip 5","OPPO Reno 11 F 5G", "Realme GT5 Pro", "IPhone 15 Pro Max", "Xiaomi 13T" };
                return outputNama[(int)inputnama];
        }

        public void getDisplayInfo()
        {
            MerkHP HP = MerkHP.Samsung;
            string namaHP = GetNamaMerkHP(HP);
            Console.WriteLine("Jenis HP anda merupakan " + HP +  " Dengan Jenis " + namaHP);
        }
    }
    
}
