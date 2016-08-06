using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogame.Gameplay
{
    /// <summary>
    /// A planet.
    /// </summary>
    public class Planet
    {
        string name;
        short fields;
        short maxFields;
        bool isHomeworld;
        short minTemperature;
        short maxTemperature;
        Resource resource;
        List<Ship> ships;
        List<Facility> structures;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Name of the planet.</param>
        /// <param name="maxFields">Maximum fields of the planet.</param>
        /// <param name="resource">Current resource of the planet.</param>
        /// <param name="fields">Current fields of the planet.</param>
        /// <param name="isHomeworld">Tells if the planet is the home world of the player.</param>
        /// <param name="minTemperature">Minimum temperature of the planet.</param>
        /// <param name="maxTemperature">Maximum temperature of the planet.</param>
        /// <param name="structures">List of the structures built on the planet.</param>
        public Planet(string name, short maxFields, Resource resource, short fields, bool isHomeworld, short minTemperature, short maxTemperature, List<Ship> ships, List<Facility> structures)
        {
            this.name = name;
            this.maxFields = maxFields;
            this.resource = resource;
            this.fields = fields;
            this.isHomeworld = isHomeworld;
            this.minTemperature = minTemperature;
            this.maxTemperature = maxTemperature;
            this.ships = ships;
            this.structures = structures;
        }

        /// <summary>
        /// Add a structure.
        /// </summary>
        /// <param name="structure">Structure to add.</param>
        public void AddStructure(Facility structure)
        {
            if (!IsFull())
            {
                structures.Add(structure);
            }
        }

        /// <summary>
        /// Remove a structure.
        /// </summary>
        /// <param name="structure">Structure to remove.</param>
        public void RemoveStructure(Facility structure)
        {
            structures.Remove(structure);
        }

        /// <summary>
        /// Check if the planet is full.
        /// </summary>
        /// <returns>True is full.</returns>
        public bool IsFull()
        {
            return fields >= maxFields;
        }
    }
}
