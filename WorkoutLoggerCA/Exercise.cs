using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public class Exercise
    {
        public Exercise(){}
        public Exercise(string name, ExerciseType exerciseType)
        {
            Name = name;
            ExerciseType = exerciseType;
        }
        public string Name { get; set; }
        public ExerciseType ExerciseType;
    }
    public enum ExerciseType
    {
        Legs,
        Arms,
        Chest,
        Shoulders,
        Back
    }
}
