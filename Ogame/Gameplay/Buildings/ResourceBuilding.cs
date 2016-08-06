using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogame.Gameplay.Buildings
{
    /// <summary>
    /// A resource building, like a mine or a power plant.
    /// </summary>
    public class ResourceBuilding : Building
    {
        Resource production;
        Resource capacity;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id">Id of the resource building.</param>
        /// <param name="name">Name of the resource building.</param>
        /// <param name="description">Description of the resource building.</param>
        /// <param name="time">Time to build the resource building.</param>
        /// <param name="cost">Cost to the build the resource building.</param>
        /// <param name="production"></param>
        /// <param name="level"></param>
        /// <param name="costFactor"></param>
        public ResourceBuilding(short id, string name, string description, float time, Resource cost, Resource production, Resource capacity, short level, float costFactor)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.time = time;
            this.cost = cost;
            this.production = production;
            this.capacity = capacity;
            this.level = level;
            this.costFactor = costFactor;
        }
    }
}