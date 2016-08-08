using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogame.Gameplay.Buildings
{
    public class Facility : Building
    {
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
        public Facility(short id, string name, string description, float time, Resource cost, short level, float costFactor) : base(id, name, description, time, cost, level, costFactor)
        {

        }

        /// <summary>
        /// Get the cost of the facility.
        /// </summary>
        /// <returns>Primary cost of the facility.</returns>
        public override Resource GetCost()
        {
            return cost;
        }
    }
}
