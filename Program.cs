using System;
namespace ImmutableID
{
    class Program
    {
        class Student
        {
            // auto-implemented properties
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // default constructor
            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }
            // parameterized constructor
            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }
            // Parameterized constructor that only takes ID
            public Student(int id)
            {
                Id = id;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            static void Main(string[] args)
            {
                // Create object using partial parameterized constructor
                Student student1 = new Student(1); //{ FirstName = "Tom", LastName = "Morrison"};
                student1.FirstName = "Tom";
                student1.LastName = "Morrison";

                // create object using parameterized constructor
                Student student2 = new Student(2, "Chris", "Morrison");


                Console.WriteLine($"Name: {student1.FirstName} {student1.LastName}\n" +
                    $"Student Id: {student1.Id}");
                Console.WriteLine($"Name: {student2.FirstName} {student2.LastName}\n" +
                    $"Student Id: {student2.Id}");
            }

        }
    }

}