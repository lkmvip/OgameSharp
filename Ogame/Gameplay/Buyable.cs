using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogame.Gameplay
{
    /// <summary>
    /// Implements everything for a buildable component.
    /// </summary>
    public abstract class Buyable
    {
        protected string name;
        protected string description;
        protected float time;
        protected Resource cost;

        /// <summary>
        /// Check if the buildable can be build.
        /// </summary>
        /// <param name="cost">Cost from the player.</param>
        /// <returns>True if the player can build it, otherwise false.</returns>
        public bool CanBuild(Resource cost)
        {
            return true;
        }

        /// <summary>
        /// Get the name of the buildable.
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Get the description of the buildable.
        /// </summary>
        public string Description
        {
            get { return description; }
        }

        /// <summary>
        /// Get the time to build / research.
        /// </summary>
        public float Time
        {
            get { return time; }
        }
    }
}
