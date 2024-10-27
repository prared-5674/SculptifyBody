using SculptifyBody.SculptifyBody.Core.Enums;

namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class UserProfile
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public FitnessGoal Goal { get; set; }
        public Dictionary<string, double> Measurements { get; set; }
    }
}
