using System;
using LibraryClass;

namespace Library_V3{

    public class Program{
        static void Main(string[] args){

            Library library = new Library();
            library.Title = "Generation 2";
            library.Author = "Marcos";
            library.Pages = 255;
            library.Status = true;

            Magazines myMagazines = new Magazines(3, 2020);
            myMagazines.Title = "Economy";
            myMagazines.Author = "Tiao";
            myMagazines.Pages = 50;
            myMagazines.Status = true;

            Photos myPhotos = new Photos("Colored");
            myPhotos.Author = "José";
            myPhotos.Title = "Memories";
            myPhotos.Pages = 1;
            myPhotos.ReleaseMonth = 5;
            myPhotos.ReleaseYear = 2021;
            myPhotos.Status = true;

            library.Discard();
            myMagazines.Discard();
            myPhotos.Discard();

            Console.WriteLine(library.Title);
            Console.WriteLine(myMagazines.Title);
            Console.WriteLine(myPhotos.Title);
        }
    }
}