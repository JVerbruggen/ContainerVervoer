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
        public UnevenShip Ship { get; private set; }

        public NewShip()
        {
            InitializeComponent();
            Ship = null;
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

        private void AddButton_Click(object sender, EventArgs e)
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

                Ship = new UnevenShip(name, stacksPerRow, rowsPerShip, maximumWeight);

                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
