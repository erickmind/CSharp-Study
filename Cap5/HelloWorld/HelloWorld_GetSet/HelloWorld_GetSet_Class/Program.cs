using System;
using MyUserClass;

namespace MyFirstClass{

    class MainProgram{
        static void Main(string[] args){
            UserInteraction request = new UserInteraction();
            request.requestInput();
            request.printInput();
            var typed = request.message;

            return;
        }
    }
}