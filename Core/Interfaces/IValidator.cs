using Core.Models;

namespace Core.Interfaces
{
    public interface IValidator<T>
    {
        ValidationResult Validator(T value);
    }
}
