using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD2022_2
{
    public class Lessons : ILessons
    {
        public string[] lessons { get; set; }
        public Lessons(string[] lessons)
        {
            this.lessons = lessons;
        }
    }
}
