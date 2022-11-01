using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface ICheckStage<T>
    {
        List<T> Check(List<T> players);
    }
}
