

//              Challenge: Student Manager
//  1. Get student name and grade from console input
//  2. Able to handle any number of students
//  3. Display all students names and grades once the user finishes adding students


using System;

namespace Student_Manager_Challenge
{
    // I create a Pupil struct to carry info of students
    // more info variables could be added to Pupil struct 
    // to add more details about each Pupil
    struct  Pupil
    {
        
        public string name;
        public int grade;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students are in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            var students = new Pupil[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name: ");
                students[i].name = Console.ReadLine();
                Console.Write("Student Grade: ");
                students[i].grade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Student Name | Grade ");
            Console.WriteLine("---------------------------");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(String.Format("{0,-12} | {1,-10} ", students[i].name, students[i].grade));
            }

            Console.WriteLine("---------------------------");


            Console.ReadLine();
        }
    }
}
