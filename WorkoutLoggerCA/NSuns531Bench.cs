using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public class NSuns531Bench : NSunsWorkoutTemplate
    {
        public NSuns531Bench(DateTime entryDate, TrainingMaxStatistics tierOneTrainingMax, TrainingMaxStatistics tierTwoTrainingMax)
                                :base(entryDate, tierOneTrainingMax, tierTwoTrainingMax) {}

        protected override void GetTierTwoExercise()
        {
            _tierTwoExericise = new Exercise("Military Press", ExerciseType.Shoulders);
        }

        protected override void CreateTierTwoLifts()
        {
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 1, 6, _tierTwoTrainingMax.TrainingMax * 0.50));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 2, 5, _tierTwoTrainingMax.TrainingMax * 0.60));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 3, 3, _tierTwoTrainingMax.TrainingMax * 0.70));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 4, 5, _tierTwoTrainingMax.TrainingMax * 0.70));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 5, 7, _tierTwoTrainingMax.TrainingMax * 0.70));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 6, 4, _tierTwoTrainingMax.TrainingMax * 0.70));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 7, 6, _tierTwoTrainingMax.TrainingMax * 0.70));
            this.TargetWorkoutSets.Add(new WorkoutSet(_tierTwoExericise, 8, 7, _tierTwoTrainingMax.TrainingMax * 0.70));
        }
    }
}
