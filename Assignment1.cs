using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class FamilyTree
    {
        static void Main()
        {
            FamilyTree tree = new FamilyTree();
            tree.PrintFamilydetails("NikhilReddy");
            Console.WriteLine("===================================================");
            tree.PrintFamilydetails("SurenderReddy");
            Console.ReadLine();
        }
        public void PrintFamilydetails(string name)
        {
            Child objchaild = new Child();
            objchaild.ChildName1 = name;
            Familydetails(objchaild);
        }
        public void Familydetails(Child obj)
        {
            string result = $"Surename :{obj.Surname} \n GrandFater :{obj.GrandParentName1} ,GrandMother :{obj.GrandParentName2} \n"
            + $" Father :{obj.ParentName1} ,Mother :{obj.ParentName2} \n Chaild :{obj.ChildName1} \n"
            + $"Location :{obj.Location} , City :{obj.City}";
            Console.WriteLine(result);
        }
    }
    public class GrandParent
    {
        public string GrandParentName1 { get; set; } = "LingaReddy";
        public string GrandParentName2 { get; set; } = "Balamani";
        public string Location { get; set; } = "11-62,Rampally,Siddipet,TS"; public string Surname { get; set; } = "Udem";
        public string City { get; set; } = "Siddipet";
}
public class Parent : GrandParent { 

public string ParentName1 { get; set; } = "Surender Reddy";
        public string ParentName2 { get; set; } = "Anitha";
    }
    public class Child : Parent
    {
        public string ChildName1 { get; set; }
    }
}

