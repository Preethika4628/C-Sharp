using System;
using System.Collections.Generic;
namespace SingleInheritance;
class Program 
{
    public static void Main(string[] args)
    {
        List<AadharDetails> aadharList = new List<AadharDetails>();
        AadharDetails aadhar = new AadharDetails("Preethika", "Sathish", Gender.Female, new DateTime(2000,11,01), "Virudhunagar");
        aadharList.Add(aadhar);

        foreach(AadharDetails aadhar1 in aadharList)
        {
            Console.WriteLine($"{aadhar1.BirthID} | {aadhar1.Name} | {aadhar1.FatherName} | {aadhar1.Gender} | {aadhar1.DOB.ToString("dd/MM/yyyy")} | {aadhar1.AadharID} | {aadhar1.Address}");
        }
        
    }
}