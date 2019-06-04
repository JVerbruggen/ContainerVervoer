using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ContainerLogic.Models
{
    public class EvenShip : BaseShip
    {
        public EvenShip(string name, int length, int width, int maxWeight) : base(name, length, width, maxWeight)
        {

        }

        protected override List<IRow> GetNewRows(int length, int width)
        {
            List<IRow> newRows = new List<IRow>();
            if (ValidDimensions(length, width))
            {
                for (int i = 0; i < length; i++)
                {
                    IRow row = new EvenRow(width);
                    newRows.Add(row);
                }
            }
            return newRows;
        }
    }
}
