namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class Meal
    {
        public string Id { get; set; }
        public MealType Type { get; set; }
        public TimeSpan ScheduledTime { get; set; }
        public List<MealItem> Items { get; set; }
        public int TotalCalories { get; set; }
        public NutritionSummary NutritionInfo { get; set; }
        public string PreparationInstructions { get; set; }
        public int PreparationTimeMinutes { get; set; }
        public List<string> CookingEquipmentNeeded { get; set; }
    }
}