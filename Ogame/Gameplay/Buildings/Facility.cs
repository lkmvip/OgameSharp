using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogame.Gameplay.Buildings
{
    public class Facility : Building
    {
        public override Resource GetCost()
        {
            return cost;
        }
    }
}
