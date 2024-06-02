using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class Room
    {
        private static int idnumber = 1;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }
        public Room(string name, double price, int personCapacity)
        {
            Id = idnumber++;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            IsAvailable = true;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"id - {Id}");
            Console.WriteLine($"name - {Name}");
            Console.WriteLine($"price - {Price}");
            Console.WriteLine($"capacity - {PersonCapacity}");
            Console.WriteLine($"is available {IsAvailable}");
        }
        public override string ToString()
        {
            return $"id: {Id}" + $"name: {Name}" + $"price: {Price}" + $"capacity: {PersonCapacity}" + $"as available: {IsAvailable}";

        }

    }                
}                  
        
