using System;

namespace Builder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            args = new string[]
            {
                "html",
            };

            if (args.Length != 1)
            {
                Usage();
            }

            if (args[0].Equals("plain"))
            {
                TextBuilder textBuilder = new TextBuilder();
                Director director = new Director(textBuilder);
                director.Construct();
                string result = textBuilder.GetResult();
                Console.WriteLine(result);
            }
            else if (args[0].Equals("html"))
            {
                HTMLBuilder htmlBuilder = new HTMLBuilder();
                Director director = new Director(htmlBuilder);
                director.Construct();
                string filename = htmlBuilder.GetResult();
                Console.WriteLine($"{filename}が作成されました。");
            }
            else
            {
                Usage();
            }
        }

        public static void Usage()
        {
            Console.WriteLine("Usage: cs Main plain : プレーンテキストで文書作成");
            Console.WriteLine("Usage: cs Main html : HTMLファイルで文書作成");
        }
    }
}

