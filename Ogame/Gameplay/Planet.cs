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
        List<Structure> structures;

        public Planet(string name, short maxFields, short fields, bool isHomeworld, short minTemperature, short maxTemperature, List<Structure> structures)
        {
            this.name = name;
            this.maxFields = maxFields;
            this.fields = fields;
            this.isHomeworld = isHomeworld;
            this.minTemperature = minTemperature;
            this.maxTemperature = maxTemperature;
            this.structures = structures;
        }

        public void AddStructure(Structure structure)
        {
            if (!IsFull())
            {
                structures.Add(structure);
            }
        }

        public void RemoveStructure(Structure structure)
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
