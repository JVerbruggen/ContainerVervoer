using ContainerLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVervoerWFA
{
    partial class NewShip : Form
    {
        public Ship ship { get; private set; }

        public NewShip()
        {
            InitializeComponent();
            ship = null;
        }

        private bool ValidateInputs()
        {
            bool validated = true;

            if(nameTextBox.Text == "" || stacksPerRowNumeric.Value <= 0 || rowsPerShipNumeric.Value <= 0 
                || maximumWeightNumeric.Value <= 0)
            {
                validated = false;
            }

            return validated;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                string name = nameTextBox.Text;
                int stacksPerRow = (int)stacksPerRowNumeric.Value;
                int rowsPerShip = (int)rowsPerShipNumeric.Value;
                int maximumWeight = (int)maximumWeightNumeric.Value * 1000;

                ship = new Ship(name, stacksPerRow, rowsPerShip, maximumWeight);

                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
