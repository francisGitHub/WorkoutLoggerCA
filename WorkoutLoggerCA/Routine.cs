using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public abstract class Routine
    {
        public DateTime StartDate;

        public WorkoutTemplate Day1;
        public WorkoutTemplate Day2;
        public WorkoutTemplate Day3;
        public WorkoutTemplate Day4;
        public WorkoutTemplate Day5;
        public WorkoutTemplate Day6;
        public WorkoutTemplate Day7;

        public abstract void CreateWorkoutTemplates();
    }

}
