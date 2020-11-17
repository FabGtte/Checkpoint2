using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Checkpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = "LOCALHOST\\SQLEXPRESS";
            stringBuilder.InitialCatalog = "CheckpointBravo";
            stringBuilder.IntegratedSecurity = true;
            DataAbstractionLayer.Open(stringBuilder);
            IEnumerable<Student> students = DataAbstractionLayer.SelectAllStudent();
            IEnumerable<Student> studentsLastName = DataAbstractionLayer.SelectStudentByLastName("Bonaparte");

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            DataAbstractionLayer.Close();

            foreach (Student student in studentsLastName)
            {
                Console.WriteLine(student);
            }
            DataAbstractionLayer.Close();
        }
    }
}
