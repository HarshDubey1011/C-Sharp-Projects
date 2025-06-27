
using System.Collections;

namespace PracticeAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lst = new ArrayList();
            Console.WriteLine("Welcome to Student Management System!");
            int choice = 0;
            StudentImpl s = new StudentImpl();
            do
            {
                Console.WriteLine("1. Add Student\r\n2. Display All Students\r\n3. Get Student\r\n4. Update Student\r\n5. Delete Student\r\n6. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine()!);

                switch(choice)
                {
                    case 1: s.addStudent(lst);break;
                    case 2: s.getAllStudents(lst);break;
                    case 3:
                        {
                            Console.WriteLine("Enter The ID Of The Student U Wanna get: ");
                            int id = int.Parse(Console.ReadLine()!);
                            Student newS = s.getStudent(lst, id);
                            Console.WriteLine(newS);
                        }break;
                    case 4:
                        {
                            Console.WriteLine("Enter The ID Of The Student U Wanna update: ");
                            int id = int.Parse(Console.ReadLine()!);
                            s.updateStudent(lst, id);
                        }break;
                    case 5:
                        {
                            Console.WriteLine("Enter The ID Of The Student U Wanna delete: ");
                            int id = int.Parse(Console.ReadLine()!);
                            s.deleteStudent(lst, id);
                        }break;
                    case 6: Environment.Exit(1);break;
                    default: Console.WriteLine("Enter the Correct choice please!");break;
                }

            } while (choice != 6);

        }
    }
}
