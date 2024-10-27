namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public UserProfile Profile { get; set; }
        public List<WorkoutPlan> WorkoutPlans { get; set; }
        public List<DietPlan> DietPlans { get; set; }
    }
}
