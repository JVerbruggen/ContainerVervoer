using ContainerLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerLogic
{
    public class ShipRepository
    {
        private List<Ship> ships;
        public IReadOnlyList<Ship> Ships => ships;

        public ShipRepository(List<Ship> ships)
        {
            this.ships = ships;
        }

        public ShipRepository()
        {
            this.ships = new List<Ship>();
        }

        public Ship NewShip(string name, int length, int width, int maxWeight)
        {
            Ship ship = new Ship(name, length, width, maxWeight);

            ships.Add(ship);

            return ship;
        }

        public void AddShip(Ship ship)
        {
            if (!ships.Contains(ship))
            {
                ships.Add(ship);
            }
        }
    }
}
