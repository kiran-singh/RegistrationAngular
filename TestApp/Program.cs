using System;

namespace TestApp
{
    class Program
    {
        static void Main()
        {
            var inherited = new InheritedClass{Name = "Inherited"};
            Console.WriteLine((inherited as BaseClass).Name);
        }
    }

    public class BaseClass
    {
        public string Name { get; set; }
    }

    public class InheritedClass : BaseClass
    {
        
    }
}
