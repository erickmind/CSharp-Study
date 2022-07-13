using static System.Console;
using System;
using System.Collections.Generic;

namespace csharpbook{
    class DataCollections{
        static void Main(string[] args){
            //Arrays
            int[] array = {1,2,3,4};
            int[,] matrix = {{1,2,3,4}, {5,6,7,8}};
            //Lists
            List<string> names = new List<string>();
            names.Add("Maria");
            names.Add("Joao");
            names.Add("Jose");
            WriteLine(names[0]);
            names.RemoveAt(0);
            WriteLine(names[0]);
        }

    }

}