using System.Text.RegularExpressions;

namespace Editorhtml
{
    public static class Leitor
    {
        public static void Show(string file)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Modod de visualização");
            Console.WriteLine("=============");
            Replace(file);
            Console.ReadKey();
            Menu.Mostrar();


        }

        public static void Replace(string file)
        {
            var strong = new Regex(@"<s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = file.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i].Substring(words[i].IndexOf('>') + 1,
                    (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')));
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(words[i]);
                    Console.Write(' ');
                }
            }
        }


        public static void Caminho_de_leitura()
        {
            Console.Clear();
            Console.WriteLine("qual o caminho para o arquivo?");
            string path = Console.ReadLine();

            using (var arquivo = new StreamReader(path))
            {
                string file = arquivo.ReadToEnd();
                Show(file);

            }

            Console.ReadKey();


        }

    }

}