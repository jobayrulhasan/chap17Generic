using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap17Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal an = new Animal { Name = "cow", Age = 3, type = AnimalType.carnivore };
            GenericAnimal<Animal> animal = new GenericAnimal<Animal>();
            Console.WriteLine(animal.GetGenericAnimal(an));
            Console.ReadKey();
        }
    }
}
