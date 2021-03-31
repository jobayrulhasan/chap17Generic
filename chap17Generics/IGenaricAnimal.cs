using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap17Generics
{
   public interface IGenaricAnimal<t>
   {
        string GetGenericAnimal(t obj);
   }
}
