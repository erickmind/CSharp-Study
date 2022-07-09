using System;
using LibraryClass;

namespace Library_V1{

    class Program{

        static void Main(string[] args){
            Library library = new Library();
            library.Title = "Generation 2";
            library.Author = "Marcos";
            library.Pages = 255;
            library.Status = true;

            Library library2 = new Library("Generation 3", "Marcos", 340, true);
            Console.WriteLine(library);
            Console.WriteLine(library2);
        }
    }

}