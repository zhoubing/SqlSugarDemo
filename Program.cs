using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace ConsoleApp1
{
    class Student
    {
        public string no { get; set; }
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "server=localhost;uid=root;pwd=123;database=test",
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
            var students = db.Queryable<Student>().ToList();
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].no);
                Console.WriteLine(students[i].name);
            }
        }
    }
}
