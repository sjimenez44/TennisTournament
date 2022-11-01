using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;

namespace Core.Services
{
    public class CheckStageMasculine : ICheckStage<MasculinePlayer>
    {
        public List<MasculinePlayer> Check(List<MasculinePlayer> players)
        {
            int numPlayers = players.Count;
            if (numPlayers > 1)
            {
                List<MasculinePlayer> result = new List<MasculinePlayer>();
                for (int i = 0; i < numPlayers / 2; i++)
                {
                    MasculinePlayer player1 = players[0 + 2 * i];
                    MasculinePlayer player2 = players[1 + 2 * i];
                    double valuePlayer1 = player1.Processor.Calculate(player1);
                    double valuePlayer2 = player1.Processor.Calculate(player2);

                    if (valuePlayer1 > valuePlayer2)
                    {
                        result.Add(player1);
                    }
                    else
                    {
                        result.Add(player2);
                    }
                }
                return result;
            }
            return players;
        }
    }
}
