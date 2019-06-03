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
        public IShip Ship { get; private set; }

        public NewShip()
        {
            InitializeComponent();
            Ship = null;
        }

        private bool ValidateInputs()
        {
            bool validated = true;

            if(nameTextBox.Text == "" || lengthNumeric.Value <= 0 || widthNumeric.Value <= 0 
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
                int width = (int)widthNumeric.Value;
                int length = (int)lengthNumeric.Value;
                int maximumWeight = (int)maximumWeightNumeric.Value * 1000;

                bool init = false;

                if(width % 2 == 0)
                {
                    Ship = new EvenShip();
                    init = Ship.Init(name, length, width, maximumWeight);
                }
                else
                {
                    Ship = new UnevenShip();
                    init = Ship.Init(name, length, width, maximumWeight);
                }

                if (!init)
                {
                    MessageBox.Show("Dimensions incorrect");
                }

                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
