using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // an example of creating a object of class Student
            var student = new Student("Skrypnyk Denis");

            // An example of creating a object of class University
            University univer = new University("NULP");

            // Adding student to university and setting their's Knowledge level
            univer.AddStudent(new Student("Kindii Vasyl", 90));
            univer.AddStudent(new Student("Oleksandr Aleksandrov", 60));
            univer.AddStudent(new Student("Ihor Mateichuk", 70));
            univer.AddStudent(new Student("Yurii Kondratyk", 40));
            univer.AddStudent(new Student("Oleh Halavin", 80));


            Internship internship = new Internship("Interlink");
            // Adding university to Internship
            internship.AddUniversity(univer);
            Console.WriteLine("List of internship's students:");
            //Get string of students whose level of knowledge is higher than the average
            Console.WriteLine(internship.GetStudents());

            Console.ReadLine();
        }
    }
}
