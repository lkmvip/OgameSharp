using System;
using System.Collections.Generic;
using System.Text;

namespace OgameSharp.Gameplay
{
    /// <summary>
    /// Cost of a ship / factory 
    /// </summary>
    public struct Cost
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
        public Cost(long metal, long crystal, long deuterium)
        {
            Metal = metal;
            Crystal = crystal;
            Deuterium = deuterium;
        }
    }
}
