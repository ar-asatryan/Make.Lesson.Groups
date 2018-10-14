using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase();
            List<Student> students = db.Students(29);
            List<Teacher> teachers = db.Teachers(7);
             
            var manager = new Manager();
            int[] arrS = manager.DistributeStudents(students, teachers);
            //manager.CreateGroup("C#", );

            Console.ReadLine();
        }

        public void PrintGroups(List<Group> groups)
        {
            //todo: Add Print Algorithm
        }


    }
}
