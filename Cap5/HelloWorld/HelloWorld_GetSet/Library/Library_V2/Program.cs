using System;
using static System.Console;
using LibraryClass;

namespace Library_V2{

    public class Program{
        static void Main(string[] args){
            Magazines myMagazines = new Magazines(3, 2020);
            myMagazines.Title = "Economy";
            myMagazines.Author = "Tiao";
            myMagazines.Pages = 50;
            myMagazines.Status = true;

            WriteLine($"{myMagazines.Title}"
            + System.Environment.NewLine
            + $"{myMagazines.Author}"
            + System.Environment.NewLine
            + $"{myMagazines.Pages}"
            + System.Environment.NewLine
            + $"{myMagazines.Status}"
            + System.Environment.NewLine
            + $"{myMagazines.ReleaseMonth}"
            + System.Environment.NewLine
            + $"{myMagazines.ReleaseYear}"
            );
        }
    }
}