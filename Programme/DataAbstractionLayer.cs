using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Checkpoint2
{
    static class DataAbstractionLayer
    {
        private static SqlConnection _connection = new SqlConnection();

        internal static void Open(SqlConnectionStringBuilder stringBuilder)
        {
            _connection.ConnectionString = stringBuilder.ConnectionString;
            _connection.Open();
        }

        internal static void Close()
        {
            _connection.Close();
        }

        internal static IEnumerable<Student> SelectAllStudent()
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM Student";
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read()) // Tant qu'il y a de la donnée je lis un enregistrement
            {
                Student student = new Student
                {
                    StudentId = reader.GetInt32(0),
                    firstname = reader.GetString(1),
                    lastname = reader.GetString(2),
                    FK_Exam = reader.GetInt32(3)
                };
                students.Add(student);
            }
            reader.Close();
            return students;
        }

        internal static IEnumerable<Student> SelectStudentByLastName(string studentlastname)
        {
            SqlCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT * FROM Student WHERE lastname = '" + studentlastname + "' ";
            SqlDataReader reader = command.ExecuteReader();
            List<Student> studentsLastName = new List<Student>();
            while (reader.Read()) // Tant qu'il y a de la donnée je lis un enregistrement
            {
                Student student = new Student
                {
                    StudentId = reader.GetInt32(0),
                    firstname = reader.GetString(1),
                    lastname = reader.GetString(2),
                    FK_Exam = reader.GetInt32(3)
                };
                studentsLastName.Add(student);
            }
            reader.Close();
            return studentsLastName;
        }
    }
}
