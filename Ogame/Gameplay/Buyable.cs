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
        protected Type type;
        protected Resource cost;
        protected Dictionary<short, short> requirementsTechnology;
        protected Dictionary<short, short> requirementsBuilding;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id">Id of the buyable.</param>
        /// <param name="name">Name of the buyable.</param>
        /// <param name="description">Description of the buyable.</param>
        /// <param name="time">Time of the buyable.</param>
        /// <param name="cost">Cost of the buyable.</param>
        public Buyable(short id, string name, string description, float time, Resource cost)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.time = time;
            this.cost = cost;
            this.requirementsBuilding = new Dictionary<short, short>();
            this.requirementsTechnology = new Dictionary<short, short>();
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

        /// <summary>
        /// Get the cost.
        /// </summary>
        public Resource Cost
        {
            get { return cost; }
        }

        /// <summary>
        /// Get or set the requirement for the buyable.
        /// </summary>
        public Dictionary<short, short> RequirementsTechnology
        {
            get { return requirementsTechnology; }
            set { requirementsTechnology = value; }
        }

        /// <summary>
        /// Get or set the requirement for the buyable.
        /// </summary>
        public Dictionary<short, short> RequirementsBuilding
        {
            get { return requirementsBuilding; }
            set { requirementsBuilding = value; }
        }

        /// <summary>
        /// Enumeration of every type of buyable.
        /// </summary>
        public enum Type : short
        {
            Ship = 1,
            Technology = 2,
            Building = 3
        }
    }
}
