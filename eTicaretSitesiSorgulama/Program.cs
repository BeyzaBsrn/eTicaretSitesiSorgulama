namespace eTicaretSitesiSorgulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("üyelik durumunuzu giriniz(evet/hayır): ");
            string uyelikDurumu = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Alışveriş tutarını giriniz: ");
            int tutar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İlk defa mı alışveriş yapıyorsunuz? (evet/hayır):");
            string ilkDefa = Console.ReadLine().Trim().ToLower();

            if((uyelikDurumu == "evet" && tutar >1000) || ilkDefa == "evet")
            {
                double indirimli = tutar * 0.85;
                Console.WriteLine($"Kampanya kazandınız! %15 indirim uygulandı.Ödemeniz gereken tutar:{indirimli} TL");
            }
            else
            {
                Console.WriteLine($"Kampanyadan yararlanamıyorsunuz.Ödemeniz gereken tutar:{tutar}TL");
            }

        }
    }
}
