using System;
using System.Collections.Generic;
using System.Text;

namespace NewContainerLogic
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
