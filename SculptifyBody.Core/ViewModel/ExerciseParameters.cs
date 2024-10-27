namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class ExerciseParameters
    {
        public int Sets { get; set; }
        public int? Reps { get; set; }                // Null for time-based exercises
        public int? DurationSeconds { get; set; }     // Null for rep-based exercises
        public double? Weight { get; set; }           // Null for bodyweight exercises
        public string WeightUnit { get; set; }        // "kg" or "lbs"
        public int? Distance { get; set; }            // For cardio exercises
        public string DistanceUnit { get; set; }      // "km", "mi", "m"
        public int? InclinePercentage { get; set; }   // For treadmill/cardio
        public int? ResistanceLevel { get; set; }     // For machines
    }
}