using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInhertiance
{
    public interface IFamilyInfo : IShowData
    {
      public string Fathername {get; set;}
      public string MotherName {get; set;}
      public string HouseAddress {get; set;}
      public int NumberOfSibling {get; set;}

        new string ShowInfo(); 
    }
}