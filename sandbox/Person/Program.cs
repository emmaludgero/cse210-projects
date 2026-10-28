using System;

class Program
{
    static void Main()
    {
        Person myPerson = new Person("Emma", "Ludgero", 22, 130);
        Console.WriteLine(myPerson.GetPersonInfo());
        Police myPolice = new Police("Gabe", "Wargha", 23, 170, "Gun");
        Console.WriteLine(myPolice.GetPoliceInfo());
        Doctor myDoctor = new Doctor("Lidia", "Costa", 36, 140, "Bisturi");
        Console.WriteLine(myDoctor.GetDoctorInfo()); 
    }
}