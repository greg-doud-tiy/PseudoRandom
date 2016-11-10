using System;

namespace GregoryDoud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine(PseudoRandom.GetInt());
            for(int idx = 0; idx < 10; idx++) {
                Console.WriteLine(PseudoRandom.GetInt(10));
            }
            var ints = PseudoRandom.GetIntSet(5, 5);
            foreach(int i in ints) {
                Console.WriteLine(i);
            }
            Console.WriteLine("Print int sequence");
            */
            var ints2 = PseudoRandom.GetIntSequence(5);
            foreach(int i in ints2) {
                Console.WriteLine(i);
            }
        }
    }
}
