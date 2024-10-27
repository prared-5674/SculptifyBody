using SculptifyBody.SculptifyBody.Core.ViewModel;

namespace SculptifyBody.SculptifyBody.Core.Interfaces
{
    public interface ICalculationService
    {
        double CalculateBMI(double heightInMeters, double weightInKg);
        double CalculateTDEE(UserProfile profile);
        double EstimateBodyFatPercentage(UserProfile profile, Dictionary<string, double> measurements);
    }
}
