using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogame.Gameplay
{
    /// <summary>
    /// A technology.
    /// </summary>
    public class Technology
    {
        short id;
        byte level;
        string name;
        string description;
        float timeResearch;
        Cost cost;
    }
}
