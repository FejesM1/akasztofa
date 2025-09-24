using System;
using System.Linq;

namespace akasztofa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            int elet = 6; 
            string betu = "";

            string[] szavak = {
                "első","alma","kukac","kutya","macska","ház","fa","autó","iskola","könyv",
                "asztal","szék","ablak","ajtó","utcán","tér","város","fal","kert","virág",
                "víz","tűz","föld","levegő","ember","kéz","lába","szív","nap","hold",
                "csillag","év","óra","perc","másodperc","évszak","tél","tavasz","nyár","ősz",
                "étel","vízum","sütő","főz","tanul","dolgozik","játszik","séta","bicikli","vonat",
                "repülő","híd","templom","bolt","piac","posta","pénz","óra","telefon","üveg",
                "ceruza","papír","festék","zene","dal","barát","család","anya","apa","testvér", "labubu"
            };
            Random rnd = new Random();
            string szo = szavak[rnd.Next(szavak.Length)];

            char[] kitalalnivalo = new char[szo.Length];
            for (int i = 0; i < kitalalnivalo.Length; i++)
                kitalalnivalo[i] = '_';

            string szitu = "";

            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════╗");
                Console.WriteLine("║        AKASZTÓFA JÁTÉK       ║");
                Console.WriteLine("╠══════════════════════════════╣");
                Console.WriteLine($"Élet: {elet}");
                RajzolAkasztofa(elet);
                Console.WriteLine("╚══════════════════════════════╝");

                Console.WriteLine(szitu);
                for (int i = 0; i < szo.Length; i++)
                    Console.Write(kitalalnivalo[i] + " ");
                Console.WriteLine("\nAdjon meg egy betűt: ");

                betu = Console.ReadLine().ToLower();

                if (betu == "")
                {
                    Console.WriteLine("Biztosan ki akarsz lépni? (i/n): ");
                    if (Console.ReadLine().ToLower() == "i") break;
                    szitu = "Nem léptél ki.";
                    continue;
                }

                if (betu.Length > 1)
                {
                    szitu = "Egyszerre csak egy betűt írj be.";
                    continue;
                }

                if (szo.Contains(betu))
                {
                    for (int i = 0; i < szo.Length; i++)
                        if (szo[i].ToString() == betu) kitalalnivalo[i] = betu[0];
                    szitu = "A szó tartalmazza a betűt :)";
                }
                else
                {
                    elet--;
                    szitu = "A szó nem tartalmazza a betűt :(";
                }

                if (elet == 0)
                {
                    Console.Clear();
                    RajzolAkasztofa(elet);
                    Console.WriteLine($"Meghaltál. A szó: {szo}");
                    break;
                }

                if (!kitalalnivalo.Contains('_'))
                {
                    Console.Clear();
                    Console.WriteLine("Nyertél! Gratulálok!");
                    break;
                }

            } while (true);
        }

        static void RajzolAkasztofa(int eletPont)
        {
            Console.WriteLine("  _______");
            Console.WriteLine("  |     |");

           
            int hibakSzama = 6 - eletPont; 

          
            if (hibakSzama >= 1) Console.WriteLine("  |     O");
            else Console.WriteLine("  |");

           
            if (hibakSzama >= 2) Console.WriteLine("  |     |");
            else Console.WriteLine("  |");

            
            if (hibakSzama == 3) Console.WriteLine("  |    /  ");      
            else if (hibakSzama >= 4) Console.WriteLine("  |    /|\\ ");   
            else Console.WriteLine("  |");

           
            if (hibakSzama == 5) Console.WriteLine("  |    /  ");      
            else if (hibakSzama >= 6) Console.WriteLine("  |    / \\");   
            else Console.WriteLine("  |");

            Console.WriteLine("  |");
        }
    }
}
