using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IGame<T>
    {
        T Game(List<T> listOfPlayers);
    }
}
