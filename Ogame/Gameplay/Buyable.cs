using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogame.Gameplay
{
    /// <summary>
    /// Implements everything for a buyable component.
    /// </summary>
    public abstract class Buyable
    {
        protected short id;
        protected string name;
        protected string description;
        protected float time;
        protected Resource cost;

        public Buyable(short id, string name, string description, float time, Resource cost)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.time = time;
            this.cost = cost;
        }

        /// <summary>
        /// Check if the buyable can be buy.
        /// </summary>
        /// <param name="cost">Cost from the player.</param>
        /// <returns>True if the player can buy it, otherwise false.</returns>
        public bool CanBuild(Resource cost)
        {
            return true;
        }

        /// <summary>
        /// Enumeration of every category.
        /// </summary>
        public enum Category
        {
            Ship = 1,
            Technology = 2,
            Facility = 3
        }

        /// <summary>
        /// Get the id of the buyable.
        /// </summary>
        public short Id
        {
            get { return id; }
        }

        /// <summary>
        /// Get the name of the buyable.
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Get the description of the buyable.
        /// </summary>
        public string Description
        {
            get { return description; }
        }

        /// <summary>
        /// Get the time to get it.
        /// </summary>
        public float Time
        {
            get { return time; }
        }

        public enum Type
        {
            Ship = 0,
            Technology = 1,
            Building = 2
        }
    }
}
