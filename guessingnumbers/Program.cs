using System;
 
namespace _5_07_2021
{
    class Program
    {
        //Sayı Tahmini
        class TahminEdilen
        {
            public int roll = 0;
            public int roll2 = 0;
            public string secenek;
            public int TahminEdilenSayı(int deneme)
           {  
                Random numberGen = new Random();
                roll = numberGen.Next(1, 7);
                
                Kontrol(roll, roll2);
                Console.WriteLine("\nSeçtiğiniz sayı " + roll + ".\nDoğru mu?(Y/N)");
                deneme++;
                secenek = Convert.ToString(Console.ReadLine());         
                if (secenek == "Y" || secenek == "y")
                {
                    return deneme;
                }
                else
                {
                    roll2 = roll; 
                    return TahminEdilenSayı(deneme);
                } 
             }
            public int Kontrol(int roll, int roll2)
            {
                if(roll2 == roll)
                {
                    Random numberGen = new Random();
                    roll = numberGen.Next(1, 7);
                    return Kontrol(roll, roll2);
                }
                else
                {
                    return roll;
                }
            }
        }
        
        static void Main(string[] args)
        {  
            bool secenek3 = true;
            while(secenek3)
            {
                TahminEdilen newTahminEdilen = new TahminEdilen();
                string secenek2;
                int attempts = 0;
           
                Console.WriteLine("\nSayı tahmin oyununa hoşgeldiniz." +
                                  "\nLütfen başlamadan önce 1 ile 6 arasıdan bir sayı seçiniz." +
                                  "\nİyi eğlenceler :)");
                attempts = newTahminEdilen.TahminEdilenSayı(attempts);
                
                Console.WriteLine("Algoritma seçtiiniz sayıyı " + attempts + " denemeden sonra buldu." +
                                "\nTekrar oynamak ister misiniz (Y/N)");
                secenek2 = Convert.ToString(Console.ReadLine());
                if(secenek2 == "N" || secenek2 == "n")
                {
                    Console.WriteLine("\nOyunadığınız için teşekkürler. Umarım beğenmişsinizdir\n");
                    secenek3 = false;
                    break;
                }
                 Console.Clear();
            }
        }
    }
}
