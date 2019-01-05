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
            DatabaseMSSQLConnection dbcnn = new DatabaseMSSQLConnection("SimpleDatabase","sa","sa");
            Student s = new Student(101, "Nguyen Van Tai", "8");
            string[] stringArr = new string[] { "101", "Nguyen Van Tai", "8" };
            //dbcnn.readData("Employees");
            //for (int i = 0; i < 10; ++i)
            //{
            //    string[] stringArr = new string[] { "10"+i, "Nguyen Van "+i, i.ToString() };
            //    dbcnn.insert("Students", stringArr);
            //}
            dbcnn.delete("Students",102);
            Console.WriteLine(dbcnn.delete("Students",101));
            //dbcnn.getTables();
            //dbcnn.getFields("Shippers");
            //dbcnn.getTypeofField("Shippers", "Phone");
            //Console.WriteLine(dbcnn.getTypeofField("Shippers", "Phone"));
            Console.ReadLine();
        }
    }
}
