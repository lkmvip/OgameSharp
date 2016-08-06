using System;
using System.Collections.Generic;
using System.Text;

namespace Ogame.Gameplay
{
    /// <summary>
    /// Cost of a ship / factory 
    /// </summary>
    public struct Resource
    {
        public long Metal;
        public long Crystal;
        public long Deuterium;
        public long Energy;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="metal">Cost in metal.</param>
        /// <param name="crystal">Cost in crystal.</param>
        /// <param name="deuterium">Cost in deuterium.</param>
        public Resource(long metal, long crystal, long deuterium)
        {
            Metal = metal;
            Crystal = crystal;
            Deuterium = deuterium;
            Energy = 0;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="metal">Cost in metal.</param>
        /// <param name="crystal">Cost in crystal.</param>
        /// <param name="deuterium">Cost in deuterium.</param>
        /// <param name="energy">Cost in energy.</param>
        public Resource(long metal, long crystal, long deuterium, long energy)
        {
            Metal = metal;
            Crystal = crystal;
            Deuterium = deuterium;
            Energy = energy;
        }
    }
}
