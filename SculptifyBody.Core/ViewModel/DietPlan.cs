namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class DietPlan
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DietType Type { get; set; }
        public List<DietDay> DietDays { get; set; }
        public NutritionGoals NutritionGoals { get; set; }
        public List<string> DietaryRestrictions { get; set; }
        public List<string> AllergiesAndIntolerances { get; set; }
        public bool IsActive { get; set; }
    }
}