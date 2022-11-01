namespace Core.Interfaces
{
    public interface ICalculateService<T>
    {
        double Calculate(T applicant);
    }
}
