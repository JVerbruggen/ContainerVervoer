using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContainerVervoerLibrary;

namespace ContainerVervoerWFA
{
    public partial class HarbourForm : Form
    {
        private Harbour harbour;

        public HarbourForm()
        {
            InitializeComponent();
            harbour = new Harbour();
        }

        private Ship NewShip()
        {
            NewShip newShip = new NewShip();
            newShip.ShowDialog();
            Ship ship = newShip.ship;

            return ship;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            int selected = shipBox.SelectedIndex;
            Ship ship;
            if(selected == -1)
            {
                ship = new Ship("testShip", 5, 5, 500000);
                AddShip(ship);
            }
            else
            {
                ship = harbour.GetShip(selected);
            }
            ShipOverviewForm shipOverviewForm = new ShipOverviewForm(ship);
            shipOverviewForm.ShowDialog();
        }

        private void AddShip(Ship ship)
        {
            harbour.AddShip(ship);
            AddShipVisually(ship);
        }

        private void AddShipVisually(Ship ship)
        {
            shipBox.Items.Add($"{ship.name} ({ship.width}x{ship.length}, {ship.maxWeight} ton)");
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            Ship ship = NewShip();

            if(ship != null)
            {
                AddShip(ship);
            }
        }
    }
}
