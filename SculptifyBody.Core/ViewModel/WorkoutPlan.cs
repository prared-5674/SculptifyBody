using SculptifyBody.SculptifyBody.Core.Enums;

namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class WorkoutPlan
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<Workout> Workouts { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public FitnessGoal Goal { get; set; }
        public TrainerPersonality TrainerType { get; set; }
    }
}