namespace a4
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> t = new HashSet<int>();

            t.Add(1);
            t.Add(2);
            t.Add(3);
            t.Add(1);

            foreach (int i in t)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
