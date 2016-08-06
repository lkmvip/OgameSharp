using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogame.Gameplay.Buildings
{
    /// <summary>
    /// Structure.
    /// </summary>
    public abstract class Building : Buyable
    {
        short level;
        float costFactor;
        Resource currentCost;
    }
}
