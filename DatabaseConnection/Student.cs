using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    class Student
    {
        public Student(Int32 id, String name, String GPA)
        {
            this.id = id;
            this.name = name;
            this.GPA = GPA;
        }

        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String gpa;

        public String GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
    }
}
