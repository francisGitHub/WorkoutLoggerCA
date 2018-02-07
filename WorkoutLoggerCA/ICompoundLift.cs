using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public interface ICompoundLift
    {
        void CreateMainLifts(TrainingMaxStatistics stats);
    }
}
