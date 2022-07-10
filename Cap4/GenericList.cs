using System;

namespace csharpbook{
    public class genericList<T>{
        public void Adding(T input){}
    }

    class TestGenercList{

        private class ExampleClass{}
        static void test(){
            genericList<int> list = new genericList<int>();
            list.Adding(1);
            
            genericList<string> list2 = new genericList<string>();
            list2.Adding("Oi");

            genericList<ExampleClass> list3 = new genericList<ExampleClass>();
            list3.Adding(new ExampleClass());
        }
    }

}