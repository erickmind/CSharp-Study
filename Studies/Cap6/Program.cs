using System;

namespace Cap6{
    public class ExceptionTreatment{

        static void Main(string[] args){
            ExceptionTreatment test = new ExceptionTreatment();
            test.ExceptionTreatmentExample();
        }
        public void ExceptionTreatmentExample(){
            Console.WriteLine("------------- Number division --------------");
            Console.WriteLine("Type the first number: ");
            var strNum = Console.ReadLine();
            Console.WriteLine("Type the second number: ");
            var strNum2 = Console.ReadLine();

            try{
                int num = int.Parse(strNum);
                int num2 = int.Parse(strNum2);
                Console.WriteLine($"Division of {num} by {num2} is: {num/num2}.");
            } catch (DivideByZeroException error) {
                Console.WriteLine($"Division by zero error: {error.Message}");
            } catch (FormatException error){
                Console.WriteLine($"FormatException error: {error.Message}");
            } catch (Exception error){
                Console.WriteLine(error.Message);
            } finally{
                Console.WriteLine("Always print this finally");
            }
            Console.WriteLine("------------- END --------------");
        }
    }
}