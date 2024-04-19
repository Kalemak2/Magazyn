using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Producer {  get; set; }
        public string Category { get; set; }
        public double Price {  get; set; }
        public DateTime DateCreated { get; set; }

        public Product(int id, string name, string producer, string description, string category, int price, DateTime datecreated)
        {
            Id = id;
            Name = name;
            Description = description;
            Producer = producer;
            Category = category;
            Price = price;
            DateCreated = datecreated;
        }
    }
}
