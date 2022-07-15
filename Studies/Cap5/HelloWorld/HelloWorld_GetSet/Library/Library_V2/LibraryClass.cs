using System;
using LibraryClass;

namespace LibraryClass{
    public class Magazines : Library{
        private int releaseMonth;
        private int releaseYear;

        public Magazines(int releaseMonth, int releaseYear){
            this.releaseMonth = releaseMonth;
            this.releaseYear = releaseYear;
        }

        public int ReleaseMonth{
            get { return this.releaseMonth; }
            set { this.releaseMonth = value; }
        }
        public int ReleaseYear{
            get { return this.releaseYear; }
            set { this.releaseYear = value; }
        }

        public override void Discard(){
            this.Title = "The magazine has been recycled.";
        }
    }
}