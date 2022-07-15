using System;

namespace csharpbook{
    public class Doctor{
        public int id { get; set; }
        public string name { get; set; }
        
        public List<Patient> patients { get; set; }
    }
    public class Patient{
        public int id { get; set; } 
        public string name { get; set; }
        public string history { get; set; } = "No history";
        public string medications { get; set; }
        public int consultationPrice { get; set; } = 0;
        public bool inHospital { get; set; } = false;
    }
}