using System;
using System.Collections.Generic;
using System.Text;

namespace OgameSharp.Gameplay
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
        int structurePoint;
        int shieldPower;
        int cargoCapacity;
        short id;
        short fuelConsumption;
        Cost cost;
        Dictionary<short, short> rapidFires;
    }
}
