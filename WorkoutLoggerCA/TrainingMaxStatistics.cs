using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public class TrainingMaxStatistics
    {
        public DateTime Date { get; set; }
        public CompoundLift CompoundLift;
        public double TrainingMax;

        public TrainingMaxStatistics(DateTime date, CompoundLift compoundLift, double trainingMax)
        {
            Date = date;
            CompoundLift = compoundLift;
            TrainingMax = trainingMax;
        }         
    }
}
