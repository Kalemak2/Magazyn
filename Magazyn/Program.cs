namespace Magazyn
{
    class Program
    {
        public static void Main(string[] args) {

            string productpath = @"product.json";

            if (!File.Exists(productpath)) {
                File.Create(productpath).Close();
                File.WriteAllText(productpath, "[]");
            }

            Menu.MenuSystem();
        }
    }
}
