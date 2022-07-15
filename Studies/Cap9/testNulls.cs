using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
using static System.Environment;
using static System.Math;

namespace csharpbook{
    public class TestNulls{
        static void Main(string[] args){
            var doc = new Doctor() { id = 1, name = "Jose" };
            WriteLine($"Dr.{doc.name} of id: {doc.id} has {doc.patients?.Count()?? 0} pacients.");
            var doc2 = new Doctor() { id=2, name = "Paula", patients = new List<Patient> 
            {
                new Patient { id=1, name="Alex", medications="Alegra", inHospital=false},
                new Patient { id=2, name="Maria", history = "Infection", consultationPrice = 200, medications="Antibiotics", inHospital=true}
            }};

            WriteLine($"--------- Patients from Dr.{doc2.name} ----------");
            doc2.patients?.ForEach( p => WriteLine(
                $"  Patient {p.id}:" 
                + NewLine
                + $"    Name: {p.name}"
                + NewLine
                + $"    History:{p.history}"
                + NewLine
                + $"    Price of Consultation: {p.consultationPrice}"
                + NewLine
                + $"    Medications: {p.medications}"));

            WriteLine($"Clinic's invoicing: { doc2.patients?.Sum(v => v.consultationPrice) }");
            WriteLine($"Number of patients in hospital: {doc2.patients?.Count(p => p.inHospital == true)}");
            WriteLine($"Number of patients who take medications: {doc2.patients?.Count(p => p.medications != null)}");
        }
    }
}