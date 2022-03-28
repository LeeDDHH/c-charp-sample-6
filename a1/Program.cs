using System.Collections.Generic;
namespace a1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(3);
            a.Add(2);
            a.Add(1);
            a.Insert(1, 4);

            int index = -1;
            foreach (int i in a) {
                index++;
                Console.WriteLine($"a[{index}]={i}");
            }
        }
    }
}
