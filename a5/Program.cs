namespace a5
{
    delegate void Operation(int a, int b);

    class Calc
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
    class Program
    {

        static void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        static void Main(string[] args)
        {
            Calc c = new Calc();

            // デリゲートの設定
            Operation o1 = new Operation(Add);
            Operation o2 = new Operation(c.Sub);

            // デリゲートで設定したメソッドの呼び出し
            o1(2, 1);
            o2(2, 1);
        }
    }
}
