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
            ProductManagement productManager = new ProductManagement();
            List<StockedProduct> products;

            string productpath = @"product.json";
            string json = File.ReadAllText(productpath);
            products = JsonSerializer.Deserialize<List<StockedProduct>>(json);

            Console.WriteLine("Witamy w magazynie!");

            string[] keys = {"Dodaj produkty", "Pokaż produkty"};
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
                    productManager.AddProducts(products);
                    break;
                case "2":
                    Console.Clear();
                    productManager.ShowProducts(products);
                    break;
                default:
                    break;

            }
        }
    }
}
