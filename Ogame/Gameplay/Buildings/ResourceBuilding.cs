using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogame.Gameplay.Buildings
{
    /// <summary>
    /// A resource building, like a mine or a power plant.
    /// </summary>
    public class ResourceBuilding : Building
    {
        Resource production;
        long metalStockage;
        long crystalStockage;
        long deuteriumStockage;
    }
}