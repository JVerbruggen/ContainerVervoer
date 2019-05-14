using ContainerLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerLogic
{
    public class ShipRepository
    {
        private List<IShip> ships;
        public IReadOnlyList<IShip> Ships => ships;

        public ShipRepository(List<IShip> ships)
        {
            this.ships = ships;
        }

        public ShipRepository()
        {
            this.ships = new List<IShip>();
        }

        public IShip NewUnevenShip(string name, int length, int width, int maxWeight)
        {
            UnevenShip ship = new UnevenShip(name, length, width, maxWeight);

            ships.Add(ship);

            return ship;
        }

        public IShip NewEvenShip(string name, int length, int width, int maxWeight)
        {
            EvenShip ship = new EvenShip(name, length, width, maxWeight);

            ships.Add(ship);

            return ship;
        }

        public void AddShip(IShip ship)
        {
            if (!ships.Contains(ship))
            {
                ships.Add(ship);
            }
        }
    }
}
