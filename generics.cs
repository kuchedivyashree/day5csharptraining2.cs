using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class GN<T>
    {
        private T data;
        public T value
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            GN<string> name = new GN<string>();
            name.value = "Generics";
            GN<float> version = new GN<float>();
            version.value = 5.0F;
            Console.WriteLine(name.value);
            Console.WriteLine(version.value);
            Console.ReadLine();
        }
    }
}

        
    




    

    

