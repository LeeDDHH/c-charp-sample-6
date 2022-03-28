namespace a3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 連想記憶クラスの生成
            Dictionary<string, string> capital = new Dictionary<string, string>();

            // データの追加
            capital["日本"] = "東京";
            capital["イギリス"] = "ロンドン";
            capital["フランス"] = "パリ";
            capital["中国"] = "北京";
            Console.WriteLine($"世界の首都");

            foreach (String s in capital.Keys)
            {
                Console.WriteLine($"{s}の首都は{capital[s]}");
            }
        }
    }
}
