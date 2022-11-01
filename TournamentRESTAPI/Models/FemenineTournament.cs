using System.Collections.Generic;

namespace TournamentRESTAPI.Models
{
    public class Tournament<T>
    {
        public string Name { get; set; }
        public List<T> Players { get; set; }
    }
}
