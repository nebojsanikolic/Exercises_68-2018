using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_68_2018
{
    class ExerciseResult
    {
        public ExerciseResult(int id, string studentName, string studentIndex, int studentPoints)
        {
            Id = id;
            StudentName = studentName;
            StudentIndex = studentIndex;
            StudentPoints = studentPoints;
        }

        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentIndex { get; set; }
        public int StudentPoints { get; set; }
    }
}
