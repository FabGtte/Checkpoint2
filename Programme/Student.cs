using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint2
{
    class Student
    {
        public int StudentId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int FK_Exam { get; set; }
        public float Average { get; set; }

        public override string ToString()
        {
            return StudentId + " " + firstname + " " + lastname + " " + FK_Exam;
        }

    }
}
