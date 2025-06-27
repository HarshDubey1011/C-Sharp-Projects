using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeAgain
{
    internal class Student
    {
        private static int GglobalId = 100;
        private int id;
        private string name;
        private int age;
        private int rollno;
        private string email;

        public Student()
        {
            name = "";
            age = 0;
            rollno = 0;
            email = "";
        }

        public Student(string name = "No Name", int age = 0, int rollno = 0, string email = "No Email") 
        {
            id = ++GglobalId;
            this.name = name;
            this.age = age;
            this.rollno = rollno;
            this.email = email;
        }

        public int ID
        {
            get => id;
          
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value.Length > 15)
                {
                    name = "No Name";
                    Console.WriteLine("Name should be less than 15 characters");
                }else
                {
                    name = value;
                }
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if(value > 65)
                {
                    age = 0;
                    Console.WriteLine("Your Age is 65. Just Give Up Now!");
                }
                else
                {
                    age = value;
                }
            }
        }

        public int RollNo
        {
            get => rollno;
            set => rollno = value;
        }

        public string Email
        {
            get => email;
            set
            {
                string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
                bool isValid = Regex.IsMatch(value, pattern);
                if(!isValid) {
                    email = "No Email";
                    Console.WriteLine("Please enter the valid Email!");
                }else
                {
                    email = value;
                }

            }
        }

        public override string ToString()
        {
            return $"ID: {ID},Name: {Name}, Age:{Age}, RollNo: {RollNo}, Email: {Email}";
        }
    }
}
