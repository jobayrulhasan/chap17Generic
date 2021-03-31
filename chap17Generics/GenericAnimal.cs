using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap17Generics
{
    class GenericAnimal<t>: IGenaricAnimal<t>
    {
        public string GetGenericAnimal(t obj)
        {
            string behavior = string.Empty;
            if (obj is Animal)
            {
                Animal a = obj as Animal;
                switch (a.type)
                {
                    case AnimalType.Harvivore:
                        behavior = ("It's takes grass as meal");
                        break;
                    case AnimalType.carnivore:
                        behavior = ("It's takes meat as meal");
                        break;
                    case AnimalType.Omnivore:
                        behavior = ("It's takes all as meal");
                        break;
                    default:
                        behavior = "unknown behavior";
                        break;
                }
            }
            else
            {
                behavior = "Not an animal";
            }
            return behavior;
        }
    }
}
