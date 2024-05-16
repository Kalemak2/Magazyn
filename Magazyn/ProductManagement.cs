using System.Text.Json;

namespace Magazyn
{
    interface IZarzadzanieProduktami
    {
        void AddProducts(List<StockedProduct> produkty);
        void ShowProducts(List<StockedProduct> produkty);
    }
    internal class ProductManagement : IZarzadzanieProduktami
    {
        public void AddProducts(List<StockedProduct> productsAdd)
        {
            Console.WriteLine("Dodawanie nowych produktów do magazynu");

             Console.Write("Podaj nazwę produktu: ");
            string name = Console.ReadLine();

            Console.Write("Podaj opis produktu: ");
            string description = Console.ReadLine();

            Console.Write("Podaj producenta produktu: ");
            string producer = Console.ReadLine();

            Console.Write("Podaj kategorię produktu: ");
            string category = Console.ReadLine();

            Console.Write("Podaj cenę produktu: ");
            double.TryParse(Console.ReadLine(), out double price);

            Console.Write("Podaj ilość produktu w magazynie: ");
            int.TryParse(Console.ReadLine(), out int stockQuantity);

            StockedProduct product = new StockedProduct(productsAdd.Count + 1, name, producer, description, category, price, DateTime.Now, stockQuantity);

            productsAdd.Add(product);

            string json = JsonSerializer.Serialize(productsAdd);
            string productsPath = @"product.json";
            File.WriteAllText(productsPath, json);

            Console.WriteLine("Produkt został dodany do magazynu!");
        }

        public void ShowProducts(List<StockedProduct> products)
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Brak produktów w magazynie!");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine($"ID: {product.Id}");
                    Console.WriteLine($"Nazwa: {product.Name}");
                    Console.WriteLine($"Opis: {product.Description}");
                    Console.WriteLine($"Producent: {product.Producer}");
                    Console.WriteLine($"Kategoria: {product.Category}");
                    Console.WriteLine($"Cena: {product.Price}");
                    Console.WriteLine($"Data utworzenia: {product.DateCreated}");
                    if (product is StockedProduct stockedProduct)
                    {
                        Console.WriteLine($"Ilość w magazynie: {stockedProduct.StockQuantity}");
                    }
                    Console.WriteLine("-----------------------");
                }
            }
        }
    }
}
