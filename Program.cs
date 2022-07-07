class Program{
    // static void Main(string[] a){
    //     Concatenação
    //     Console.WriteLine("Olá " + name);  

    //     Interpolação
    //     Console.WriteLine($"Olá {a[0]}");

    //     Console.Write("Digite o seu ano de nascimento: ");
    //     int year = int.Parse(Console.ReadLine());
    //     int age = 2022 - year;
    //     Console.WriteLine($"Você tem: {age} anos");

    //     if(age >= 18) Console.WriteLine("Você é maior de idade!");
    //     else if (age == 12) Console.WriteLine("Você tem 12 anos.");
    //     else Console.WriteLine("Você é menor de idade!");

    //     /*
    //     Comentario de multiplas linhas

    //     if(age >= 18){
    //         Console.WriteLine("Você é maior de idade!");
    //     }else if{
    //         Console.WriteLine("Você tem 12 anos.");
    //     }else{
    //         Console.WriteLine("Você é menor de idade!");
    //     }*/

    //     Arrays
    //     string[] names = {"Carlos", "Lucas", "Mariana"};

    //     for(int i=0; i < names.Length; i++){
    //         Console.WriteLine(names[i]);
    //     }

    //     foreach
    //     foreach (string name in names){
    //         if(string.Equals(name, "LuCaS", StringComparison.OrdinalIgnoreCase)) // Ignora Case Sensitive
    //             Console.WriteLine(name);
    //     }

    //     // Conversão de String para inteiro usando métodos da classe int
    //     if (int.TryParse("LKala", out int x)){
    //         Console.WriteLine(x);
    //     } else {
    //         Console.WriteLine("Erro");
    //     }

    //     int i = 106546;
    //     long l = 1076;

    //     // Cast(Conversão) implícito
    //     l = i;

    //     // Cast(Conversão) explícito
    //     i = (int)l;

    //     //Cast(Conversão) para String
    //     string s = l.ToString();
    //     Console.WriteLine(s); 

    //     //Objetos guardam referência para outros objetos (tipo de referência), enquanto variáveis de valor guardam valores em memoria (tipo de valor)
    //     Test t = new Test();
    //     t.x = 10;
    //     Test t2 = t;
    //     t2.x = 20;
    //     Console.WriteLine(t.x);
    //     int ab = 1;
    //     int ba = ab;
    //     ba = 2;
    //     Console.WriteLine(ab);
        
    //     // Objetos são anuláveis
    //     t = null;
    //     if(t == null){
    //         Console.WriteLine("t anulável");
    //     }

    //     // Tipos de valor podem ser do tipo anulavel usando ?
    //     int? nulo = null;
    //     if(nulo is null){ 
    //         Console.WriteLine("nulo anulável");
    //     }
    //     nulo = 2;
    //     if(nulo is not null){
    //         Console.WriteLine("nulo não nulo");
    //         nulo = null;
    //     }

    //     Console.WriteLine(nulo.GetValueOrDefault(1)); // retorna valor padrão caso seja nulo. O valor padrão pode ser definido como parâmetro

    //     int[] array = { 21 };
    //     string excpt = null;
    //     try{
    //         //Console.WriteLine(excpt.Length);
    //         i = array[1];
    //     } catch (System.NullReferenceException exception){
    //         Console.WriteLine($"Erro de referência nula: {exception.Message}");
    //     } catch (System.IndexOutOfRangeException exception){
    //         Console.WriteLine($"Erro de acesso a index invalido do Array: {exception.Message}");
    //     } catch (Exception exception){
    //         Console.WriteLine($"Exception aleatório: {exception.Message}");
    //     }



    // }

    // class Test{

    //         public int x;
    //     }

    static void Main(){
        
    
    }
    class bankAccount{
        string name;
        decimal balance;
    }
}