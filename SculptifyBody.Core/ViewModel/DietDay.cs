namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class DietDay
    {
        public string Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public List<Meal> Meals { get; set; }
        public NutritionSummary DailyNutritionSummary { get; set; }
        public int TotalCalories { get; set; }
        public int WaterIntakeGoalMl { get; set; }
    }
}