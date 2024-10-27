using SculptifyBody.SculptifyBody.Core.Enums;
using SculptifyBody.SculptifyBody.Core.ViewModel;

namespace SculptifyBody.SculptifyBody.Core.Interfaces
{
    public interface ITrainerService
    {
        Task<WorkoutPlan> GenerateWorkoutPlanAsync(User user, TrainerPersonality trainer);
        Task<string> GetTrainerMessageAsync(TrainerPersonality trainer, string context);
        Task<List<Exercise>> GetRecommendedExercisesAsync(UserProfile profile, FitnessGoal goal);
    }
}
