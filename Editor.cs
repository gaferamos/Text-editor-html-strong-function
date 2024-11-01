

using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace Editorhtml
{

    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Novo arquivo");
            Console.WriteLine("=============");
            Start();

        }

        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine(" Deseja salvar o arquivo? (Sim/Nao)");


            var opcao_de_salvamento = Console.ReadLine().ToLower();
            Save(file.ToString(), opcao_de_salvamento);




        }

        public static void Save(string file, string opcao_de_salvamento)
        {



            switch (opcao_de_salvamento)
            {
                case "sim":
                    {
                        Console.Clear();
                        Console.WriteLine("onde deseja alvar?");
                        var path = Console.ReadLine();

                        using (var arquivo = new StreamWriter(path))
                        {
                            arquivo.Write(file);
                        }
                        Console.WriteLine($"texto salvo com exito em {path}");
                        Thread.Sleep(1000);
                        Menu.Mostrar();

                    }
                    break;
                case "nao":
                    {
                        Console.Clear();
                        Console.WriteLine("Arquivo descartado");
                        Thread.Sleep(2500);
                        Console.Clear();
                        Console.Write("...");
                        Thread.Sleep(1000);
                        Console.Clear();                       
                        Console.Write("..");
                        Thread.Sleep(1000);
                        Console.Clear();                       
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Menu.Mostrar();

                    }
                    break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Por favor, escolha 'Sim' ou 'Nao'.");
                        Console.WriteLine("Deseja salvar o arquivo? (Sim/Nao)");
                        opcao_de_salvamento = Console.ReadLine().ToLower();
                        Save(file, opcao_de_salvamento);
                    }
                    break;
            }

        }
    }
}
