namespace ConsoleApp17
{
    internal class Program
    {
        static void Main()
        {
            Student student1 = new Student("fuad", "memmedov", "AB106", 30);
            student1.GetInfo();
            student1.CheckGraduation();
            student1.GetDiplomDegree();

            Console.WriteLine();

            Student student2 = new Student("shahin", "alizade", "AB106", 41);
            student2.GetInfo();
            student2.CheckGraduation();
            student2.GetDiplomDegree();

            Student student3 = new Student("rauf", "dostuyev ", "AB106", 14);
            student3.GetInfo();
            student3.CheckGraduation();
            student3.GetDiplomDegree();

            Student student4 = new Student("sahib", "mammadov", "AB106", 30);
            student4.GetInfo();
            student4.CheckGraduation();
            student4.GetDiplomDegree();
        }
    }
}