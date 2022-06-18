using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD2022_2
{
  
    public class Student : IStudent
    {
        public int age { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public Student(int age, string name, string email, string password)
        {
            this.age = age;
            this.id = password;
            this.name = name;
            this.email = email;
        }
    }
}
