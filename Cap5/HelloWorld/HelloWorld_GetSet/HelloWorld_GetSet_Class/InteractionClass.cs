using System;

namespace MyUserClass{
    class UserInteraction{

        private string _typedMessage;
        public string  message{
            get { return message; }
            set { _typedMessage = value; }
        }
        public void requestInput(){
            _typedMessage = Console.ReadLine();
        }

        public void printInput(){
            Console.WriteLine(_typedMessage);
        }

    }

}