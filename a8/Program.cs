namespace a8
{
    class Program
    {

        static int GetNum(int i)
        {
            int[] nums = { 300, 600, 900 };
            if (i > nums.Length)
            {
                // 例外を発生させる
                throw new IndexOutOfRangeException();
            }
            return nums[i];
        }
        static void Main(string[] args)
        {
            try
            {
                int result = GetNum(4);
            }
            catch (System.Exception)
            {
                
                Console.WriteLine($"配列の範囲外にアクセスしました。");
            }

        }
    }
}
