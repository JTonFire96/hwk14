using System;

namespace hwk14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            String y = "cake";
            float z = 2.1f;
            Double q = 2.25;
            bool t = true;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(q);
            Console.WriteLine(t);
            Console.WriteLine("The recipe for the {0} requires {1} cups of water, {1} eggs and {2} bars of coco.", y, x, q);
            Console.ReadKey();
            Console.Write("Name your favorite fruit: ");
            string fruit = Console.ReadLine();
            Console.WriteLine(fruit);
            Console.ReadKey();

            Console.WriteLine(2 < 4);
            Console.WriteLine("coding" != "fun");
            Console.WriteLine("angry" == "angry" && "love" == "hate");
            Console.WriteLine(!true);
            Console.ReadKey();


        }
    }
}
