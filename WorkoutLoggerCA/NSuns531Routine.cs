using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public class NSuns531Routine : Routine
    {
        readonly TrainingMaxStatistics _overheadPress;
        readonly TrainingMaxStatistics _bench;
        readonly TrainingMaxStatistics _squat;
        readonly TrainingMaxStatistics _deadlift;

        public NSuns531Routine(DateTime startDate,
                               TrainingMaxStatistics overheadPress,
                               TrainingMaxStatistics bench,
                               TrainingMaxStatistics squat,
                               TrainingMaxStatistics deadlift)
        {
            StartDate = startDate;
            _overheadPress = overheadPress;
            _bench = bench;
            _squat = squat;
            _deadlift = deadlift;
            CreateWorkoutTemplates();
        }

        public override void CreateWorkoutTemplates()
        {
            Day1 = new NSuns531Bench(StartDate, _bench, _overheadPress);
            Day2 = new NSuns531Squat(StartDate.AddDays(1), _squat, _deadlift);
            Day4 = new NSuns531OverheadPress(StartDate.AddDays(3), _overheadPress, _bench);
            Day5 = new NSuns531Deadlift(StartDate.AddDays(4), _deadlift, _squat);
        }
    }
}
