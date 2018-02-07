using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutLoggerCA
{
    public abstract class NSunsWorkoutTemplate : WorkoutTemplate, ICompoundLift
    {
        protected TrainingMaxStatistics _tierOneTrainingMax;
        protected TrainingMaxStatistics _tierTwoTrainingMax;
        public CompoundLift _tierOneExercise;
        public Exercise _tierTwoExericise;

        public NSunsWorkoutTemplate() { }

        public NSunsWorkoutTemplate(DateTime entryDate,
                                    TrainingMaxStatistics tierOneTrainingMax,
                                    TrainingMaxStatistics tierTwoTrainingMax)
        {
            EntryDate = entryDate;
            _tierOneTrainingMax = tierOneTrainingMax;
            _tierTwoTrainingMax = tierTwoTrainingMax;
            _tierOneExercise = tierOneTrainingMax.CompoundLift;
            CreateWorkoutSets();
        }
        
        public override void CreateWorkoutSets()
        {
            CreateMainLifts(_tierOneTrainingMax);
            GetTierTwoExercise();
            CreateTierTwoLifts();
        }

        public void CreateMainLifts(TrainingMaxStatistics stats)
        {
            this.TargetWorkoutSets.Add(new WorkoutSet(stats.CompoundLift, 1, 5, stats.TrainingMax * 0.75));
            this.TargetWorkoutSets.Add(new WorkoutSet(stats.CompoundLift, 2, 3, stats.TrainingMax * 0.85));
            this.TargetWorkoutSets.Add(new WorkoutSet(stats.CompoundLift, 3, 1, stats.TrainingMax * 0.95));
            this.TargetWorkoutSets.Add(new WorkoutSet(stats.CompoundLift, 4, 3, stats.TrainingMax * 0.90));
            this.TargetWorkoutSets.Add(new WorkoutSet(stats.CompoundLift, 5, 3, stats.TrainingMax * 0.85));
            this.TargetWorkoutSets.Add(new WorkoutSet(stats.CompoundLift, 6, 3, stats.TrainingMax * 0.80));
            this.TargetWorkoutSets.Add(new WorkoutSet(stats.CompoundLift, 7, 5, stats.TrainingMax * 0.75));
            this.TargetWorkoutSets.Add(new WorkoutSet(stats.CompoundLift, 8, 5, stats.TrainingMax * 0.70));
            this.TargetWorkoutSets.Add(new WorkoutSet(stats.CompoundLift, 9, 5, stats.TrainingMax * 0.65));
        }

        protected abstract void GetTierTwoExercise();
        protected abstract void CreateTierTwoLifts();

        public TrainingMaxStatistics RecalculateTrainingMax()
        {
            TrainingMaxStatistics newTrainingMax = new TrainingMaxStatistics(DateTime.Now, _tierOneExercise, _tierOneTrainingMax.TrainingMax);
            if (this.Completed )
            {
                // We'll compare the one rep max of the target set,
                // to the one rep max acheived in the actual workout

                var TargetOneRepMax = GetTargetOneRepMaxSet();
                var WorkoutOneRepMax = GetWorkoutOneRepMaxSet();

                if (WorkoutOneRepMax != null)
                {
                    double weightIncrease = 0;
                    if (WorkoutOneRepMax.Repetitions > 5)
                        weightIncrease = 10;
                    else if (WorkoutOneRepMax.Repetitions >= 4)
                        weightIncrease = 5;
                    else if (WorkoutOneRepMax.Repetitions >= 2)
                        weightIncrease = 2.5;

                    newTrainingMax.TrainingMax += weightIncrease;
                }
            }
            return newTrainingMax;
        }

        private WorkoutSet GetTargetOneRepMaxSet()
        {
            return TargetWorkoutSets.Where(exercise => exercise.Exercise == _tierOneExercise && exercise.SetNumber == 3).FirstOrDefault();
        }

        private WorkoutSet GetWorkoutOneRepMaxSet()
        {
            WorkoutSet workoutSet = null;
            workoutSet = WorkoutSets.Where(exercise => exercise.Exercise == _tierOneExercise && exercise.SetNumber == 3).FirstOrDefault();
            return workoutSet;
        }
    }
}
