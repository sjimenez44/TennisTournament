using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;

namespace Core.Services
{
    public class CheckStageFeminine : ICheckStage<FemininePlayer>
    {
        public List<FemininePlayer> Check(List<FemininePlayer> players)
        {
            int numPlayers = players.Count;
            if (numPlayers > 1)
            {
                List<FemininePlayer> result = new List<FemininePlayer>();
                for (int i = 0; i < numPlayers / 2; i++)
                {
                    FemininePlayer player1 = players[0 + 2 * i];
                    FemininePlayer player2 = players[1 + 2 * i];
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
