using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public class WorkoutSet
    {
        public WorkoutSet() {}

        public WorkoutSet(Exercise exercise,
                          int setNumber,
                          int repetitions,
                          double weight)
        {
            SetNumber = setNumber;
            Repetitions = repetitions;
            Weight = weight;
            Exercise = exercise;
        }

        public WorkoutSet(Exercise exercise,
                          int setNumber,
                          int repetitions,
                          double trainingMax,
                          double percentage)
        {
            SetNumber = setNumber;
            Repetitions = repetitions;
            Weight = trainingMax * percentage;
            Exercise = exercise;
        }

        public int SetNumber { get; set; }
        public int Repetitions { get; set; }
        public double Weight { get; set; }
        public Exercise Exercise { get; set; }
        
    }
}
