using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
   public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        

        public override string ToString()
        {
            return string.Format("Student Information:\n\tId:{0},\n\tName:{1},\n\tDegree:{2}" 

               ,Id,Name,Degree);
        } 
    }
}

