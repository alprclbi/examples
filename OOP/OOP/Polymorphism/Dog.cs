using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Hav Hav !!");
        }
    }
}
