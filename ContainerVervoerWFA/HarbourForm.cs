using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContainerLogic;
using ContainerLogic.Models;

namespace ContainerVervoerWFA
{
    public partial class HarbourForm : Form
    {
        private ShipRepository repository;

        public HarbourForm()
        {
            InitializeComponent();
            repository = new ShipRepository();
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
                ship = repository.NewShip("testShip", 5, 5, 500000);
                AddShip(ship);
            }
            else
            {
                ship = repository.Ships[selected];
            }
            ShipOverviewForm shipOverviewForm = new ShipOverviewForm(ship);
            shipOverviewForm.ShowDialog();
        }

        private void AddShip(Ship ship)
        {
            repository.AddShip(ship);
            AddShipVisually(ship);
        }

        private void AddShipVisually(Ship ship)
        {
            shipBox.Items.Add($"{ship.Name} ({ship.Width}x{ship.Length}, {ship.MaxWeight} ton)");
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
