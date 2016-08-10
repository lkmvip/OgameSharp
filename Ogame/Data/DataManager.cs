using Formattor.Core;
using Ogame.Gameplay;
using Ogame.Gameplay.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogame.Data
{
    /// <summary>
    /// Manager which load every data stored in the Formattor file.
    /// </summary>
    static public class DataManager
    {
        static Dictionary<short, Ship> Ships;
        static Dictionary<short, Technology> Technologies;
        static Dictionary<short, Building> Buildings;

        /// <summary>
        /// Loading the data.
        /// </summary>
        /// <param name="path">Path of the file.</param>
        static public void Load(string path)
        {
            Ships = new Dictionary<short, Ship>();
            Technologies = new Dictionary<short, Technology>();
            Buildings = new Dictionary<short, Building>();

            FormattorFile file = FormattorFile.Load(path);

            LoadTechnologies(file);
            LoadBuildings(file);
            LoadShips(file);
        }

        /// <summary>
        /// Loading every ships.
        /// </summary>
        /// <param name="file">Current formattor file.</param>
        static public void LoadShips(FormattorFile file)
        {

        }

        /// <summary>
        /// Loading every technologies.
        /// </summary>
        /// <param name="file">Current formattor file.</param>
        static public void LoadTechnologies(FormattorFile file)
        {

        }

        /// <summary>
        /// Loading every buildings.
        /// </summary>
        /// <param name="file">Current formattor file.</param>
        static public void LoadBuildings(FormattorFile file)
        {

        }
    }
}
