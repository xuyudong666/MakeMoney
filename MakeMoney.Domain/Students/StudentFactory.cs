using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMoney.Domain.Students {
    public class StudentFactory {
       
        public Student CreateAsync(string name) {
            return new Student(name);
        }
    }
}
