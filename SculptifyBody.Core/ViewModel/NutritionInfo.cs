namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class NutritionInfo
    {
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }
        public double Fiber { get; set; }
        public double Sugar { get; set; }
        public double SaturatedFat { get; set; }
        public double UnsaturatedFat { get; set; }
        public double Sodium { get; set; }
        public Dictionary<string, double> Vitamins { get; set; }
        public Dictionary<string, double> Minerals { get; set; }
    }
}