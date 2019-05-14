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

        private IShip NewShip()
        {
            NewShip newShip = new NewShip();
            newShip.ShowDialog();
            IShip ship = newShip.Ship;

            return ship;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            int selected = shipBox.SelectedIndex;
            IShip ship;
            if(selected == -1)
            {
                ship = repository.NewUnevenShip("testShip", 5, 5, 50000000);
                AddShip(ship);
            }
            else
            {
                ship = repository.Ships[selected];
            }
            ShipOverviewForm shipOverviewForm = new ShipOverviewForm(ship);
            shipOverviewForm.ShowDialog();
        }

        private void AddShip(IShip ship)
        {
            repository.AddShip(ship);
            AddShipVisually(ship);
        }

        private void AddShipVisually(IShip ship)
        {
            shipBox.Items.Add($"{ship.Name} ({ship.Width}x{ship.Length}, {ship.MaxWeight} kg)");
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            IShip ship = NewShip();

            if(ship != null)
            {
                AddShip(ship);
            }
        }
    }
}
