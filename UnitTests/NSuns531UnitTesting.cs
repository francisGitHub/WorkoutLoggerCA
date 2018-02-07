using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkoutLoggerCA;

namespace UnitTests
{
    [TestClass]
    public class NSuns531UnitTests
    {
        private NSuns531Bench _bench;
        private TrainingMaxStatistics _benchStats;
        private TrainingMaxStatistics _ohpStats;
        private List<WorkoutSet> _benchWorkoutSets = new List<WorkoutSet>();

        [TestInitialize]
        public void Setup()
        {
            CompoundLift overheadPress = new CompoundLift("Overhead Press", ExerciseType.Shoulders);
            CompoundLift bench = new CompoundLift("Bench", ExerciseType.Chest);

            _ohpStats = new TrainingMaxStatistics(DateTime.Now, overheadPress, 60);
            _benchStats = new TrainingMaxStatistics(DateTime.Now, bench, 100);

            DateTime startDate = new DateTime(2018, 1, 1);

            _bench = new NSuns531Bench(startDate, _benchStats, _ohpStats);

            //Hypothetical TierOne Bench Workout
            _benchWorkoutSets.Add(new WorkoutSet(_bench._tierOneExercise, 1, 5, 75));
            _benchWorkoutSets.Add(new WorkoutSet(_bench._tierOneExercise, 2, 3, 85));
            _benchWorkoutSets.Add(new WorkoutSet(_bench._tierOneExercise, 3, 2, 95));
            _benchWorkoutSets.Add(new WorkoutSet(_bench._tierOneExercise, 4, 3, 90));
            _benchWorkoutSets.Add(new WorkoutSet(_bench._tierOneExercise, 5, 3, 85));
            _benchWorkoutSets.Add(new WorkoutSet(_bench._tierOneExercise, 6, 3, 80));
            _benchWorkoutSets.Add(new WorkoutSet(_bench._tierOneExercise, 7, 5, 75));
            _benchWorkoutSets.Add(new WorkoutSet(_bench._tierOneExercise, 8, 5, 70));
            _benchWorkoutSets.Add(new WorkoutSet(_bench._tierOneExercise, 9, 5, 65));

        }

        [TestMethod]
        public void NineTierOneExerciseSetsCreated()
        {
            var tierOneSets = _bench.TargetWorkoutSets.Where(exercise => exercise.Exercise == _bench._tierOneExercise);
            Assert.AreEqual(tierOneSets.Count(), 9);
        }

        [TestMethod]
        public void NoWorkoutSetTraningMaxRecalc()
        {
            TrainingMaxStatistics benchStats = _bench.RecalculateTrainingMax();
            

            Assert.AreEqual(benchStats.TrainingMax, 100);
        }

        [TestMethod]
        public void WorkoutCompleteTraningMaxRecalc()
        {
            _bench.LogSet(_benchWorkoutSets);
            _bench.Completed = true;

            TrainingMaxStatistics benchStats = _bench.RecalculateTrainingMax();

            Assert.AreEqual(benchStats.TrainingMax, 102.5);
        }        
    }
}
