using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public class NSuns531Deadlift : NSunsWorkoutTemplate
    {
        public NSuns531Deadlift(DateTime entryDate, TrainingMaxStatistics tierOneTrainingMax, TrainingMaxStatistics tierTwoTrainingMax)
                                : base(entryDate, tierOneTrainingMax, tierTwoTrainingMax) { }

        protected override void GetTierTwoExercise()
        {
            _tierTwoExericise = new Exercise("Front Squat", ExerciseType.Legs);
        }

        protected override void CreateTierTwoLifts()
        {
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 1, 5, _tierTwoTrainingMax.TrainingMax * 0.70));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 2, 3, _tierTwoTrainingMax.TrainingMax * 0.80));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 3, 1, _tierTwoTrainingMax.TrainingMax * 0.90));
        }
    }
}
