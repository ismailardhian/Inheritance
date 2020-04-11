using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Zara Adhisty", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Udil Surbakti", 42, 190304, "Logical Information", "surbakti@amikom.ac.id");
            teacher.GetNameAndAge();

            Student student = new Student("Ismail Ardhian Fadhola", 19, 2724, "ismail.fa@student.amikom.ac.id");
            student.GetNameAndAge();
        }
    }
}