using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Magazyn
{
    internal class ProductManagement
    {
        public static void AddProducts() {

            List <Product> productsAdd = new List<Product>();

            Console.WriteLine("Dodawanie nowych produktów do zamówienia");

            Console.Write("Podaj nazwe produktu: ");
            string? name = Console.ReadLine();

            Console.Write("Podaj opis produktu: ");
            string? decription = Console.ReadLine();

            Console.Write("Podaj producenta produktu: ");
            string? producer = Console.ReadLine();

            Console.Write("Podaj kategorie produktu: ");
            string? category = Console.ReadLine();

            Console.Write("Podaj cenę produktu: ");
            if (!(int.TryParse(Console.ReadLine(), out int price)))
                price = 0;

            Product products = new Product(productsAdd.Count + 1, name, decription, producer, category, price, DateTime.Now);
            productsAdd.Add(products);
            string json = JsonSerializer.Serialize(productsAdd);
            string productspath = @"product.json";
            File.WriteAllText(productspath, json);;
            Console.WriteLine("Produkt został dodany!");
        }

        public static void ShowProducts()
        {
            List<Product> productsAdd = new List<Product>();

            string productpath = @"product.json";
            string json = File.ReadAllText(productpath);
            productsAdd = JsonSerializer.Deserialize<List<Product>>(json);

            if (productsAdd.Count == 0)
            {
                Console.WriteLine("Brak produktów w magazynie!");
            }
            else
            {
                foreach (var produkty in productsAdd)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine($"ID: {produkty.Id}");
                    Console.WriteLine($"Nazwa: {produkty.Name}");
                    Console.WriteLine($"Opis: {produkty.Description}");
                    Console.WriteLine($"Producent: {produkty.Producer}");
                    Console.WriteLine($"Kategoria: {produkty.Category}");
                    Console.WriteLine($"Cena: {produkty.Price}");
                    Console.WriteLine($"Data utworzenia: {produkty.DateCreated}");
                    Console.WriteLine("-----------------------");
                }
            }
        }
    }
}







































































