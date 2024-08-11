class Program
{
    public static void Main(string[] args)
    {
        //
        //coffe dinamik listemizi oluşturuyoruz
        List<string> coffee = new List<string>();
        //bilgi mesajları
        Console.WriteLine("Bir Kahve İçsek Bize İyi Gelecek !");
        Console.WriteLine("****************************************");
        Console.WriteLine("! ! ! DİKKAT ! ! ! EN FAZLA 5 KAHVE ÇEŞİTİ GİREBİLİRSİN ! ! ! DİKKAT ! ! !");
        //kullanıcıdan kahve girişleri için bilgileri alıyoruz
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{i + 1} . Kahve Çeşidini Giriniz ");
            string input = Console.ReadLine();
            coffee.Add(input);//listeye girilen değeri ekliyoruz
        }
        //Girilen Değerleri Listeliyoruz
        Console.WriteLine("******************************");
        Console.WriteLine("Girilen Kahve İsimleri : ");
        int sayac = 1;
        foreach (string item in coffee)
        {
            Console.WriteLine($"{sayac ++} - {item}");
        }
    }
}