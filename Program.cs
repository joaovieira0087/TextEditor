using System;
using System.Numerics;


namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        
        static void Menu()
        {
            Console.WriteLine("Text Editor Menu:");
            Console.WriteLine("1. Open Document");
            Console.WriteLine("2. Create New Document");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: OpenDocument(); break;
                case 2: CreateNewDocument(); break;

                default: Menu(); break;
            }

            static void OpenDocument()
            {

            }
            
            static void CreateNewDocument()
            {

            }
        }
    }
}
