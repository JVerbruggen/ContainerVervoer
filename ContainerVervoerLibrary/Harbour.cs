using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoerLibrary
{
    public class Harbour
    {
        private List<Ship> ships;
        private List<IContainer> notLoadedContainers;

        public Harbour()
        {
            ships = new List<Ship>();
            notLoadedContainers = new List<IContainer>();
        }

        //public IReadOnlyCollection<IContainer> LoadShip(List<IContainer> containers, Ship ship)
        //{
        //    while(containers.Count > 0 && ship.weight < ship.maxWeight)
        //    {
        //        IContainer container = containers[0];
        //        ship.AddContainer(container);
        //    }

        //    return containers;
        //}

        public Ship NewShip(string name, int width, int length, int maxWeight)
        {
            Ship ship = new Ship(name, width, length, maxWeight);
            AddShip(ship);
            return ship;
        }

        public Ship GetShip(int i)
        {
            Ship ship = null;
            if(i < ships.Count)
            {
                ship = ships[i];
            }
            return ship;
        }

        public bool CanStartLoading(Ship ship)
        {
            return ship.weight >= ship.maxWeight / 2 ;
        }

        public void AddShip(Ship ship)
        {
            ships.Add(ship);
        }
    }
}
