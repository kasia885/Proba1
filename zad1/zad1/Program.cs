using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new WlasnaLista<int>();
            lista.Add(5);

            foreach (var i in lista)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }

    class WlasnaLista<T> : System.Collections.CollectionBase
    {
        public void Add(T element)
        {
            List.Add(element);
        }
    }
}
