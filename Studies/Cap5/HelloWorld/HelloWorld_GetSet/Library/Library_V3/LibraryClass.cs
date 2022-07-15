namespace LibraryClass{

    public class Photos : Magazines{

        private string type;
        public Photos(string type) : base (0, 0){
            this.type = type; 
        }
        
            public string Type{
            get { return type; }
            set { type = value;}
        }

        public override void Discard()
        {
            this.Title = "The photo has been destroyed";
        }
    }

}