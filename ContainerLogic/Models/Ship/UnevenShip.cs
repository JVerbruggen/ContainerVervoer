using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ContainerLogic.Models
{

    public class UnevenShip : BaseShip
    {
        public UnevenShip() : base()
        {

        }

        protected override List<IRow> GetNewRows(int length, int width)
        {
            List<IRow> newRows = new List<IRow>();
            if (length > 0 && length <= 20)
            {
                for (int i = 0; i < length; i++)
                {
                    IRow row = new UnevenRow(width);
                    newRows.Add(row);
                }
            }
            return newRows;
        }
    }
}
