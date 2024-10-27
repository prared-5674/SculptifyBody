namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class Exercise
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ExerciseType Type { get; set; }
        public MuscleGroup PrimaryMuscleGroup { get; set; }
        public List<MuscleGroup> SecondaryMuscleGroups { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public List<string> RequiredEquipment { get; set; }
        public ExerciseInstructions Instructions { get; set; }
        public int RestPeriodSeconds { get; set; }
        public bool RequiresSpotter { get; set; }
        public ExerciseParameters Parameters { get; set; }
    }
}