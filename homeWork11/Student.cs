using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork11
{
    class Student
    { 
        public (string surname, string name, string patronymic) FullName { get; private set; }
        public string Group { get; private set; }
        public string Faculty { get; private set; }
        public string Course { get; private set; }
        public int Age { get; private set; }
        public (byte day, byte month, int year) Birthday { get; private set; }
        public string Gender { get; private set; }

        public Student() { }

        public Student ((string surname, string name, string patronymic)fullName, 

                       string group, string faculty, string course,

                       int age, (byte day,byte month, int year) birthday, string gender)
        {
            FullName = fullName;
            Group = group;
            Faculty = faculty;
            Course = course;
            Age = age;
            Birthday = birthday;
            Gender = gender;
        }

        public void SetFullName(string surname, string name, string patronymic)
        {
            if (name == "" || surname == "" || patronymic == "") Console.WriteLine("\nEmpty value!");
            else FullName = (surname, name, patronymic);
        }

        public string GetFullName()
        {
            return FullName.surname + " " + FullName.name + " " + FullName.patronymic;
        }

        public void Info()
        {
            Console.WriteLine($"Name: {FullName}\n"+ 
                              $"\nAge: {Age}\n" + 
                              $"\nDate of Birth: {Birthday}\n" + 
                              $"\nGender: {Gender}\n" + 
                              $"\nGroup: {Group}\n" + 
                              $"\nFaculty: {Faculty}\n" + 
                              $"\nCourse: {Course}\n");
        }
        public void Transfer(string group, string faculty)
        {
            if (group == "" || faculty == "") Console.WriteLine("\nEmpty value!");
            else
            {
                Group = group; 
                Faculty = faculty;
            }
        }



    }
}
