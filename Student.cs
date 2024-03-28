using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Student
    {
       public string Name;
       public string Surname;
       public string Group;
       public int Point;
       public bool IsGruated;

        public Student(string name, string surname,string group, int point, bool isGruated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGruated = isGruated;
        }
        public  void GetInfo()
        {
            Console.WriteLine($"Name; {Name}; \nSurname; {Surname} \nGroup; {Group} \npoint; {Point} \nisGruated; {IsGruated}");
        }
        public void CheckGraduation()
        {
            Console.WriteLine($"Graduation Status: {(IsGruated ? "Bu telebe mezun olub" : "Mezun olmayib")}");
        }
        public void GetDiplomDegree()
        { 
            if (Point<65)
            {
                Console.WriteLine("yoxdur");
            }
            else if (Point >=65 && Point <80)
            {
                Console.WriteLine("adi");
            }
            else if (Point >=80 && Point <90)
            {
                Console.WriteLine("seref");
            }
            else
            {
                Console.WriteLine("yuksek seref");
            }
        }

    }
}
