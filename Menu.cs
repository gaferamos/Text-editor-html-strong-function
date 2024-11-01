using System;
using System.Security.Cryptography.X509Certificates;
namespace Editorhtml
{
    public static class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Borda_da_tela();
            Opcoes();

            var option = short.Parse(Console.ReadLine());
            OptionHandler(option);
        }



        public static void Borda_da_tela()
        {
            Linha();
            Coluna();
            Linha();



        }

        public static void Linha()
        {


            Console.Write('+');

            for (int i = 0; i < 60; i++)
            {
                Console.Write('-');
            }
            Console.Write('+');
            Console.WriteLine();

        }

        public static void Coluna()
        {
            for (int linhas = 0; linhas < 15; linhas++)
            {
                Console.Write("!");
                for (int j = 0; j < 60; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("!");
                Console.WriteLine();
            }



        }


        public static void Opcoes()
        {
            Console.SetCursorPosition(25, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("=====================");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Selecione uma opção");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(2, 7);
            Console.Write("Opção: ");




        }


        public static void OptionHandler(short option)
        {

            switch (option)
            {
                case 1:
                    {
                        Editor.Show();
                        break;
                    }

                case 2:
                    {
                        Leitor.Caminho_de_leitura();
                        break;
                    }

                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }

                default:
                    {
                        Mostrar();
                        break;
                    }

            }
        }


    }
}
