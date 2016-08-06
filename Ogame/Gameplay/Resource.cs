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
        }
    }
}
