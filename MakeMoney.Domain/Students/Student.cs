using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MakeMoney.Domain.Students {
    public class Student {

        private Student() {

        }

        internal Student(string name) {
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public void SetName(string name) {
            //if（长度大于20 必须是中文）
            Name = name;
        }

        //payOrder() {

        //}
    }
}
