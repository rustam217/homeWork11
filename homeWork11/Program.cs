using System;

namespace homeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(("Shamiev", "Rustam", "Ruslanovich"), "CS2001",
                                            "IT-academy", "C#", 21,(20,2,1999),"Male");
            student1.Info();

            Console.WriteLine("-------------------------------------------------" +
                              "\nCalled SetFullName method :");

            student1.SetFullName("Sabyrov", "Audin", "");

            Console.WriteLine($"After set Empty field: {student1.FullName}");


           student1.SetFullName("Sabyrov", "Audin", "Nurlanovich");
            Console.WriteLine(student1.FullName);

            Console.WriteLine("-------------------------------------------------" +
                              "\nCalled GetFullName method :");

            Console.WriteLine(student1.GetFullName());

            Console.WriteLine("-------------------------------------------------" +
                             "\nCalled Info method :");

            student1.Info();
 
            Console.WriteLine("-------------------------------------------------" +
                             "\nCalled Transfer method :");
            student1.Transfer("","Smaiti-academy");

            Console.WriteLine($"After set Empty field: {student1.Group + ", " + student1.Faculty}");
           
            student1.Transfer("JAVA2001", "Smaiti-academy");

            Console.WriteLine(student1.Group + " , " + student1.Faculty);
        }
    }
}
