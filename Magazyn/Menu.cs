using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Magazyn
{
    internal class Menu
    {
        public static void MenuSystem() {

            Console.WriteLine("Witamy w magazynie!");
            string[] keys = {"Dodaj produkty", "Pokaż produkty", "Złóż zamówienie", "Pokaż zamówienie", "Zakończ" };
            int number = 1;
            foreach(string key in keys)
            {
                Console.WriteLine($"{number}.{key}");
                number++;
            }
            Console.Write("Wybierz opcję żeby przejść dalej: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    ProductManagement.AddProducts();
                    break;
                case "2":
                    Console.Clear();
                    ProductManagement.ShowProducts();
                    break;
                case "3":
                    Console.Clear();
                    break;
                case "4":
                    Console.Clear();
                    break;
                case "5":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine();
                    break;

            }
        }
    }
}
