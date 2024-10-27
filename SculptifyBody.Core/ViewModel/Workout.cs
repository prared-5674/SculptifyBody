using SculptifyBody.SculptifyBody.Core.Enums;

namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class Workout
    {
        public string Id { get; set; }
        public DateTime ScheduledDate { get; set; }
        public List<Exercise> Exercises { get; set; }
        public WorkoutIntensity Intensity { get; set; }
        public int EstimatedDurationMinutes { get; set; }
    }
}