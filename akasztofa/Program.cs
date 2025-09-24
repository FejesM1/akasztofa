using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace akasztofa
{
    
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int elet = 10;
            string betu = "";
            betu = betu.ToLower();
            
            string[] szavak = {
                "első","alma","kukac","kutya","macska","ház","fa","autó","iskola","könyv",
                "asztal","szék","ablak","ajtó","utcán","tér","város","fal","kert","virág",
                "víz","tűz","föld","levegő","ember","kéz","lába","szív","nap","hold",
                "csillag","év","óra","perc","másodperc","évszak","tél","tavasz","nyár","ősz",
                "étel","vízum","sütő","főz","tanul","dolgozik","játszik","séta","bicikli","vonat",
                "repülő","híd","templom","bolt","piac","posta","pénz","óra","telefon","üveg",
                "ceruza","papír","festék","zene","dal","barát","család","anya","apa","testvér", "labubu"
            };
            
                string szitu = "";
                Random rnd = new Random();
                string szo = szavak[rnd.Next(szavak.Length)];
                char[] kitalalnivalo = new char[szo.Length];
                for (int i = 0; i < kitalalnivalo.Length; i++)
                {
                    kitalalnivalo[i] = '_';
                }
                Console.Title = "Akasztófa játék";

            

            do
                {
                Console.WriteLine("╔══════════════════════════════╗");
                Console.WriteLine("║        AKASZTÓFA JÁTÉK       ║");
                Console.WriteLine("╠══════════════════════════════╣");
                    Console.WriteLine($"Élet: {elet}");
                Console.WriteLine("╚══════════════════════════════╝");
                Console.WriteLine(szitu);
                for (int i = 0; i < szo.Length; i++)
                    {
                        Console.Write(kitalalnivalo[i] + " ");
                    }

                    Console.WriteLine("\nAdjon meg egy betűt: ");
                    betu = Console.ReadLine().ToLower();
                    

                if (betu == "")
                {
                    Console.WriteLine("Biztosan ki akarsz lépni? (i/n): ");
                    string valasz = Console.ReadLine().ToLower();
                    if (valasz == "i")
                    {
                        break;
                    }
                    else
                    {
                        szitu = "Nem léptél ki.";
                        continue;
                    }
                }
               
                if (szo.Contains(betu))
                {
                    
                    for (int i = 0; i < szo.Length; i++)
                    {
                        if (szo[i].ToString() == betu)
                        {
                            kitalalnivalo[i] = betu[0];
                         
                        }
                    }
                   
                    szitu = "A szó tartalmazza a betűt :)\n";
                    
                }
                else if (betu.Length > 1)
                {
                    szitu = "Egyszerre csak egy betűt írj be.";
                }
                
                else
                {
                    elet--;
                    
                    szitu = "A szó nem tartalmazza a megadott betűt. :(\n";
                    
                }

                     if (elet == 0)
                    {
                        szitu = "Meghaltál. A kitalálandó szó {szo} volt";
                        break;
                    }
                else if (!kitalalnivalo.Contains('_'))
                {
                    Console.Clear();    
                    szitu = "Nyertél";
                    break;
                }Console.Clear();
                } while (true);
            
        }
    }
}
