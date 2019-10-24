using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
     class Program
    {
        

        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("Enter Name");
            s.Name = Console.ReadLine();
            Console.WriteLine("Enter Id");
            s.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Degree");
            s.Degree = Console.ReadLine();
            
            string strResultJson = JsonConvert.SerializeObject(s);
            Console.WriteLine(strResultJson);


            Student resultStudent = JsonConvert.DeserializeObject<Student>(strResultJson);
            Console.WriteLine(string.Join(", ", resultStudent.ToString()));
           // foreach (var de in resultStudent.ToString())
           // {
              //  Console.WriteLine(resultStudent.Name);
              //  Console.WriteLine(resultStudent.Id);
              //  Console.WriteLine(resultStudent.Degree);
           // }
            Console.ReadKey();
        }
    }
}

