using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGroups
{
    class DataBase
    {
        public List<Student> Students(int count)
        {
            var list = new List<Student>(count);            
            for (int i = 0; i < count; i++)
            {
                var stud = new Student { name = $"A{i+1}", surname = $"A{i+1}yan", email = $"A{i+1}@gmail.com" };
                list.Add(stud);
            }
            return list;
        }

        public List<Teacher> Teachers(int count)
        {
            var list = new List<Teacher>(count);
            for (int i = 0; i < count; i++)
            {
                var teach = new Teacher { name = $"Teach{i + 1}", surname = $"Teach{i + 1}yan", email = $"Teach{i + 1}@gmail.com" };
                list.Add(teach);
            }
            return list;
        }

        


    }
}
