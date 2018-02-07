using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public class CompoundLift: Exercise
    {
        public CompoundLift() {}
        public CompoundLift(string name, ExerciseType exerciseType)
        {
            Name = name;
            ExerciseType = exerciseType;
        }
    }
}
