using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAgain
{
    internal interface StudentInter
    {
        Boolean addStudent(ArrayList lst);

        Student getStudent(ArrayList lst, int id);

        void getAllStudents(ArrayList lst);

        Boolean updateStudent(ArrayList lst,int id);

        void deleteStudent(ArrayList lst, int id);

    }
}
