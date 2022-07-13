namespace csharpbook{
    class TextFunctions{

        static void Main(string[] args){
            Console.WriteLine("---------- Trim -----------");
            string company = "   Microsoft Corporation    ";
            Console.WriteLine($"Company's name: {company.Trim()}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------- Length -----------");
            Console.WriteLine($"Variable size: {company.Length}");
            company = company.Trim();
            Console.WriteLine($"Variable size with Trim: {company.Length}");
            Console.WriteLine("---------- Upper -----------");
            Console.WriteLine($"Upper: {company.ToUpper()}");
            Console.WriteLine("---------- Lower -----------");
            Console.WriteLine($"Lower: {company.ToLower()}");

            Console.WriteLine("---------- Upper/Lower Comparison -----------");
            var upperName = "LALA";
            var lowerName = "lala";
            if (upperName == lowerName)
                Console.WriteLine("1-Equal");
            else
                Console.WriteLine("1-Different");

            if(upperName.ToLower() == lowerName)
                Console.WriteLine("2-Equal");
            else
                Console.WriteLine("2-Different");

            if(upperName.Equals(lowerName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("3-Equal");
            else
                Console.WriteLine("3-Different");
            
            Console.WriteLine("---------- First Names -----------");
            string[] nomes = {"Francisco Gaga", "Paulo Cesar", "Mariana Dias"}; 
            foreach(string nome in nomes){
                Console.WriteLine(nome.Remove(nome.IndexOf(" ")));
            }

            Console.WriteLine("---------- Replace -----------");
            company = company.Replace("Microsoft", "Google");
            Console.WriteLine(company);
            
            Console.WriteLine("---------- Split/Count -----------");
            string text = "Lorem Ipsum of a test string";
            string[] splitted = text.Split(" ");
            int count = 0;
            foreach(string split in splitted){
                Console.WriteLine($"Text {count++}:{split}");
            }
            Console.WriteLine($"Text Count: {splitted.Count()}");

            Console.WriteLine("---------- Split/Count -----------");
            Console.WriteLine(text.Substring(6));

            string[] fruits = {"3 bananas", "65 apples", "1 grape"};
            int qnt = 0;
            foreach(string fruit in fruits){
                qnt += int.Parse(fruit.Substring(0, fruit.IndexOf(" ")));
                Console.WriteLine(fruit.Substring(fruit.IndexOf(" ")+1));
            }
            Console.WriteLine($"Number of fruits: {qnt}");

            Console.WriteLine("---------- isNullOrEmpty -----------");

            string name = "Erick";
            string lastName = null;

            if(!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(lastName))
                Console.WriteLine($"Full name: {name} {lastName}");
            else
                Console.WriteLine($"Name: {name}");

            Console.WriteLine("---------- isNullOrEmpty -----------");
        }
    }
}