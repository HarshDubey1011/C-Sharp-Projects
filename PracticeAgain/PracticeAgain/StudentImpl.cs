using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAgain
{
    class StudentImpl : StudentInter
    {
        public Boolean addStudent(ArrayList lst)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Enter your Age: ");
            int age = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter your Roll No: ");
            int rollno = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter your Email: ");
            string email = Console.ReadLine()!;

            Student stud = new Student(name,age,rollno,email);
            lst.Add(stud);
            return true;

        }

        public void deleteStudent(ArrayList lst, int id)
        {
            bool found = false;
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                Student s = lst[i] as Student;
                if (s != null && s.ID == id)
                {
                    lst.RemoveAt(i);
                    Console.WriteLine("Student with ID {0} deleted.", id);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("ID Not Found");
            }
        }


        public Student getStudent(ArrayList lst, int id)
        {
            foreach (var item in lst)
            {
                Student s = item as Student;
                if (s != null && s.ID == id)
                {
                    return s;
                }
            }

            Console.WriteLine("Student ID is not found!");
            return null;
        }

        public Boolean updateStudent(ArrayList lst, int id)
        {
                Student stud = getStudent(lst, id);

            if (stud != null)
            {
                Console.WriteLine("Enter New Name: ");
                string name = Console.ReadLine()!;
                Console.WriteLine("Enter New Age: ");
                int age = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter New Roll No: ");
                int rollno = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter New Email: ");
                string email = Console.ReadLine()!;

                stud.Name = name;
                stud.Age = age;
                stud.RollNo = rollno;
                stud.Email = email;

                Console.WriteLine("Student Updated Successfully!");
                return true;
            }else
            {
                Console.WriteLine("Student ID Not Found!");
                return false;
            }
        }

        public void getAllStudents(ArrayList lst)
        {
            foreach(var l in lst)
            {
                Console.WriteLine(l.ToString());
            }
        }
    }
}
