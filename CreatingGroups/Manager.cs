using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGroups
{
    class Manager
    {

        public int[] DistributeStudents(List<Student> students, List<Teacher> teachers)
        {
            int[] arr = new int[teachers.Count];
            int i = teachers.Count;
            int sts = students.Count;
            while (i != 0)
            {
                int unit_group = sts / i;
                arr[i - 1] = unit_group;
                sts -= unit_group;
                i--;
            }
            return arr;            
        }


    }
}
