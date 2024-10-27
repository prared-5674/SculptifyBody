namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class MealItem
    {
        public string Id { get; set; }
        public string FoodName { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public NutritionInfo NutritionPer100g { get; set; }
        public List<string> Substitutions { get; set; }
        public bool IsOptional { get; set; }
        public string ServingSuggestion { get; set; }
    }
}