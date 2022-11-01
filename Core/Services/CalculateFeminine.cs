using Core.Interfaces;
using Core.Models;

namespace Core.Services
{
    public class CalculateFeminine : ICalculateService<FemininePlayer>
    {
        public double Calculate(FemininePlayer applicant)
        {
            return applicant.Lucky < 1.12
                ? (applicant.Ability - applicant.ReactionTime) * applicant.Lucky
                : (applicant.Ability + applicant.ReactionTime) * applicant.Lucky;
        }
    }
}
