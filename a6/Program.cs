namespace a6
{
    class Program
    {

        // デリゲートの宣言
        delegate void Action(int a);

        static void Func1(int a)
        {
            Console.WriteLine($"a={a}");
        }

        static void Func2(int a)
        {
            Console.WriteLine($"a*2={a*2}");
        }

        static void Func3(int a)
        {
            Console.WriteLine($"a*3={a*3}");
        }

        static void Main(string[] args)
        {
            Action a = new Action(Func1);
            a += new Action(Func2);
            a += new Action(Func3);
            a(3);
        }
    }
}
