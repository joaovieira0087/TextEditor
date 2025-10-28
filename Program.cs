using System;
using System.Numerics;
using System.IO;


namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        
        static void Menu()
        {
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1. Abrir Documento");
            Console.WriteLine("2. Criar Novo Documento");
            Console.WriteLine("0. Sair");
            Console.Write("selecione uma opção: ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;

                default: Menu(); break;
            }

            static void Abrir()
            {
                Console.Clear();
                Console.WriteLine("Qual o caminho do arquivo?");
                string path = Console.ReadLine();

                using (var file = new StreamReader(path))
                {
                    string text = file.ReadToEnd();
                    Console.WriteLine(text);
                }

                Console.WriteLine("");
                Console.ReadLine();
                Menu();
            }
            
            static void Editar()
            {
                Console.Clear();
                Console.WriteLine("Digite seu texto abaixo (ESC para sair):");
                Console.WriteLine("----------------------");
                string Text = "";

                do
                {
                    Text = Text + Console.ReadLine();
                    Text = Text + Environment.NewLine;
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);

                Console.Write(Text);

                Salvar(Text);

            }
            
            static void Salvar(string text)
            {
                Console.Clear();
                Console.WriteLine("Qual caminho para salvar o arquivo?");
                var path = Console.ReadLine();

                using (var file = new StreamWriter(path))
                {
                    file.Write(text);
                }

                Console.WriteLine($"Arquivo salvo em {path}");
                Menu();
            }
        }
    }
}
