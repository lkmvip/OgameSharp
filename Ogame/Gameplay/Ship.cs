using System;
using System.Collections.Generic;
using System.Text;

namespace Ogame.Gameplay
{
    /// <summary>
    /// A ship.
    /// </summary>
    public class Ship
    {
        string name;
        string description;
        int speed;
        int attack;
        int leaul; //for test purpose.
        int structurePoints;
        int shieldPower;
        int cargoCapacity;
        float timeBuild;
        short id;
        short fuelConsumption;
        Cost cost;
        Dictionary<short, short> rapidFires;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id">Id of the ship.</param>
        /// <param name="name">Name of the ship.</param>
        /// <param name="description">Description of the ship.</param>
        /// <param name="speed">Speed of the ship.</param>
        /// <param name="attack">Attack of the ship.</param>
        /// <param name="structurePoints">Structure points of the ship.</param>
        /// <param name="shieldPower">Shield power of the ship.</param>
        /// <param name="cargoCapacity">Cargo capacity of the ship.</param>
        /// <param name="fuelConsumption">Fuel consumption of the ship.</param>
        /// <param name="cost">Cost of the ship.</param>
        /// <param name="rapidFires">Rapid fires of the ship.</param>
        public Ship(short id, string name, string description, int speed, int attack, int structurePoints, int shieldPower, int cargoCapacity, short fuelConsumption, Cost cost, Dictionary<short, short> rapidFires)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.speed = speed;
            this.attack = attack;
            this.structurePoints = structurePoints;
            this.shieldPower = shieldPower;
            this.cargoCapacity = cargoCapacity;
            this.fuelConsumption = fuelConsumption;
            this.cost = cost;
            this.rapidFires = rapidFires;
        }
    }
}
