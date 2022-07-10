namespace LibraryClass{

    public class Library{

        private string title;
        private string author;
        private int pages;
        private bool status;

        public Library(){

        }

        public Library(string title, string author, int pages, bool status){
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.status = status;
        }

        public string Title{
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author{
            get { return this.author; }
            set { this.author = value; }
        }

        public int Pages{
            get { return this.pages; }
            set { this.pages = value; }
        }

        public bool Status{
            get { return this.status; }
            set { this.status = value; }
        }

        public virtual void Discard(){
            title = "This book has been donated.";
        }
    }
}