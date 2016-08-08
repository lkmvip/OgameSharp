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

        public Building(short id, string name, string description, float time, Resource cost, short level, float costFactor) : base(id, name, description, time, cost)
        {
            this.level = level;
            this.costFactor = costFactor;
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
