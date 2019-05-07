using ContainerLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerLogic
{
    public class ShipRepository
    {
        private List<Ship> ships;

        public ShipRepository(List<Ship> ships)
        {
            this.ships = ships;
        }
    }
}
