using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton t1 = Singleton.instance;
            Singleton t2 = Singleton.instance;
            Console.WriteLine(Singleton.ReferenceEquals(t1, t2) == true);
            Console.WriteLine(Singleton.instance);
        }
    }
}
