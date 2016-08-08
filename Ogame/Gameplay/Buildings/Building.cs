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
        protected short level;
        protected float costFactor;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id">Id of the resource building.</param>
        /// <param name="name">Name of the resource building.</param>
        /// <param name="description">Description of the resource building.</param>
        /// <param name="time">Time to build the resource building.</param>
        /// <param name="cost">Cost to the build the resource building.</param>
        /// <param name="level"></param>
        /// <param name="costFactor"></param>
        public Building(short id, string name, string description, float time, Resource cost, short level, float costFactor) : base(id, name, description, time, cost)
        {
            this.level = level;
            this.costFactor = costFactor;
            this.type = Type.Building;
        }

        /// <summary>
        /// Get the cost of the building.
        /// </summary>
        public abstract Resource GetCost();

        /// <summary>
        /// Get the time to build the building.
        /// </summary>
        /// <returns>Time in seconds.</returns>
        public float GetTime()
        {
            Resource cost = GetCost();

            return (cost.Metal * cost.Crystal) / 2500f;
        }

    }
}
