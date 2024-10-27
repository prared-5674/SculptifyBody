namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class NutritionSummary
    {
        public double TotalCalories { get; set; }
        public MacronutrientSummary Macros { get; set; }
        public Dictionary<string, double> MicronutrientTotals { get; set; }
        public List<string> NutritionalWarnings { get; set; }
        public bool MeetsNutritionGoals { get; set; }
    }
}