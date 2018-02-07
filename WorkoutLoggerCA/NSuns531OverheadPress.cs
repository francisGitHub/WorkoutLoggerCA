using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public class NSuns531OverheadPress : NSunsWorkoutTemplate
    {
        public NSuns531OverheadPress(DateTime entryDate, TrainingMaxStatistics tierOneTrainingMax, TrainingMaxStatistics tierTwoTrainingMax)
                                : base(entryDate, tierOneTrainingMax, tierTwoTrainingMax) { }

        protected override void GetTierTwoExercise()
        {
            _tierTwoExericise = new Exercise("Incline Bench", ExerciseType.Chest);
        }

        protected override void CreateTierTwoLifts()
        {
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 1, 5, _tierTwoTrainingMax.TrainingMax * 0.75));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 2, 3, _tierTwoTrainingMax.TrainingMax * 0.85));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 3, 1, _tierTwoTrainingMax.TrainingMax * 0.95));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 4, 3, _tierTwoTrainingMax.TrainingMax * 0.90));

        }
    }
}
