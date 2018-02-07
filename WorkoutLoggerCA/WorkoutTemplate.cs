using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public abstract class WorkoutTemplate : Workout
    {
        public List<WorkoutSet> TargetWorkoutSets = new List<WorkoutSet>();

        public abstract void CreateWorkoutSets();
    }

    
}
