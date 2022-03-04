using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Complex
    {


        int real, img;
        public Complex()
        {
            real = 0;
            img = 0;
        }
        public void setValue(int r, int i)
        {
            real = r;
            img = i;
        }
        public void DisplayValue()
        {
            Console.WriteLine("Real=" + real);
            Console.WriteLine("Imaginary=" + img);
        }
        ~Complex()
        {
            Console.WriteLine("Destructor was called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex C = new Complex();
            C.setValue(2, 3);
            C.DisplayValue();
            Console.ReadLine();
        }
    }
}


    

