using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public class Workout
    {
        public DateTime EntryDate { get; set; }

        public bool Completed { get; set; }

        public List<WorkoutSet> WorkoutSets = new List<WorkoutSet>();

        public void LogSet(WorkoutSet workingSet)
        {
            WorkoutSets.Add(workingSet);
        }
        public void LogSet(List<WorkoutSet> workingSet)
        {
            WorkoutSets.AddRange(workingSet);
        }
    }
}
