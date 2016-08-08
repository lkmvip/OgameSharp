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
    public class Technology : Buyable
    {
        byte level;
        float costFactor;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id">Id of the technology.</param>
        /// <param name="name">Name of the technology.</param>
        /// <param name="description">Description of the technology.</param>
        /// <param name="time">Time to search the technology.</param>
        /// <param name="cost">Cost of the technology.</param>
        /// <param name="level">Level of the technology.</param>
        /// <param name="requirements">Requirements for the technology.</param>
        public Technology(short id, string name, string description, float time, Resource cost, byte level, float costFactor) : base(id, name, description, time, cost)
        {
            this.costFactor = costFactor;
            this.level = level;
        }

        /// <summary>
        /// Get the level of the technology.
        /// </summary>
        public byte Level
        {
            get { return level; }
        }
    }
}
