using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMoney.Domain.Students
{
    public class Student
    {

        private Student()
        {

        }

        internal Student(string name)
        {
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        public void SetName(string name) {
            Name = name;
        }
    }
}
