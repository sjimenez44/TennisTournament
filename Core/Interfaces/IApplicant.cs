using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IApplicant
    {
        string Name { get; set; }
        int Ability { get; set; }
        double Lucky { get; set; }
    }
}
