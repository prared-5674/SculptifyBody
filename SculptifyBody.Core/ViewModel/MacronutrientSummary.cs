namespace SculptifyBody.SculptifyBody.Core.ViewModel
{
    public class MacronutrientSummary
    {
        public double ProteinGrams { get; set; }
        public double CarbGrams { get; set; }
        public double FatGrams { get; set; }
        public double FiberGrams { get; set; }

        public double ProteinCalories => ProteinGrams * 4;
        public double CarbCalories => CarbGrams * 4;
        public double FatCalories => FatGrams * 9;

        public double ProteinPercentage => ProteinCalories / (ProteinCalories + CarbCalories + FatCalories) * 100;
        public double CarbPercentage => CarbCalories / (ProteinCalories + CarbCalories + FatCalories) * 100;
        public double FatPercentage => FatCalories / (ProteinCalories + CarbCalories + FatCalories) * 100;
    }
}