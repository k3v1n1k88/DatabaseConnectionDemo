using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    class Hello
    {
        static void Main()
        {
            DatabaseMSSQLConnection dbcnn = new DatabaseMSSQLConnection();
            Student s = new Student(101, "Nguyen Van Tai", "8");
            //dbcnn.addMore(s);
            //dbcnn.delete(s);
            dbcnn.update(s);
        }
    }
}
