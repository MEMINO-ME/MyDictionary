using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> customers = new MyDictionary<string, int>();
            customers.Add("Muhammed Emin", 123);
            customers.Add("Onur", 456);
            customers.Add("Burçak", 789);

            customers.List();
        }
    }
}
