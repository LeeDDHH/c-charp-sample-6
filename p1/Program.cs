namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();

            while (true)
            {
                Console.Write($"正の整数を入力してください：");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    intList.Add(num);
                }
                else
                {
                    break;
                }
            }

            foreach (int i in intList)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine($"");

            Console.WriteLine($"合計値: {intList.Sum()}");
            Console.WriteLine($"平均値: {intList.Average()}");
            Console.WriteLine($"最大値: {intList.Max()}");
            Console.WriteLine($"最小値: {intList.Min()}");
        }
    }
}
