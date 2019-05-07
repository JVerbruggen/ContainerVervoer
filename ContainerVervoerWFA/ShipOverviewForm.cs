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
    partial class ShipOverviewForm : Form
    {
        private int minX = 50;
        private int minY = 35;
        private int maxX;
        private int maxY;

        private Ship ship;
        private List<Button> buttons;
        private List<Button> containerStackButtons;

        private Stack shownStack;
        private ContainerVervoerLibrary.IContainer shownContainer;

        public ShipOverviewForm(Ship ship)
        {
            InitializeComponent();

            buttons = new List<Button>();
            containerStackButtons = new List<Button>();
            this.ship = ship;

            maxX = Size.Width - 360;
            maxY = Size.Height - 120;

            overviewTitleLabel.Text = ship.name;

            PlaceStackButtons(ship, buttons);
            UpdateWeightText();

            containerStackButtons = InitStackButtons(containerStackButtons);
            InitStackButtonsGroupBox(containerStackButtons);

            shownStack = null;
        }

        private List<Button> InitStackButtons(List<Button> containerStackButtons)
        {
            for(int i = 0; i < 10; i++)
            {
                Button containerButton = new System.Windows.Forms.Button();
                
                containerButton.Enabled = false;
                containerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                containerButton.Location = new System.Drawing.Point(6, 541 - (56 * i));
                containerButton.Name = $"containerButton-{ i }";
                containerButton.Size = new System.Drawing.Size(88, 52);
                containerButton.TabIndex = 0;
                containerButton.UseVisualStyleBackColor = true;
                containerButton.Click += new System.EventHandler(containerButtonClick);

                containerStackButtons.Add(containerButton);
            }

            return containerStackButtons;
        }

        private GroupBox InitStackButtonsGroupBox(List<Button> containerStackButtons)
        {
            GroupBox stackProperties = new System.Windows.Forms.GroupBox();

            stackProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            foreach(Button button in containerStackButtons)
            {
                stackProperties.Controls.Add(button);
            }
            stackProperties.Location = new System.Drawing.Point(855, 10);
            stackProperties.Name = "stackProperties";
            stackProperties.Size = new System.Drawing.Size(100, 599);
            stackProperties.Text = "Stack";

            Controls.Add(stackProperties);

            stackProperties.Show();

            return stackProperties;
        }

        public void containerButtonClick(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                Button button = (Button)sender;
                int id = int.Parse(button.Name.Split('-')[1]);
                shownContainer = shownStack.GetContainers()[id];
                loadEditContainerGroupBox(shownContainer.weight, shownContainer.valuable);

            }
        }

        private void RemoveButtons(List<Button> buttons)
        {
            foreach(Button button in buttons)
            {
                button.Dispose();
            }
            buttons.Clear();
        }

        private void UpdateWeightText()
        {
            shipWeightLabel.Text = $"{ship.weight}/{ship.maxWeight} kg";
        }

        public void RefreshStackButtons(Ship ship, List<Button> buttons)
        {
            int rows = ship.length;
            int columns = ship.width;

            int rowUp = 0;
            int index = 0;
            for (int i = rows - 1; i >= 0; i--) // right to left
            {
                for (int j = 0; j < columns; j++) // up to down
                {
                    Stack thisStack = ship.GetStack(rowUp, j);

                    Button button = buttons[index];
                    if (thisStack != null)
                    {
                        button.Text = thisStack.weight + " kg";
                    }
                    else
                    {
                        button.Text = "x0 kg";
                    }

                    index++;
                }

                rowUp++;
            }
        }

        public void PlaceStackButtons(Ship ship, List<Button> buttons)
        {
            RemoveButtons(buttons);

            int rows = ship.length;
            int columns = ship.width;

            int dX = maxX - minX;
            int dY = maxY - minY;

            int buttonWidth = dX / rows - 4;
            int buttonHeight = dY / columns - 4;

            int tabIndex = 5;
            int rowUp = 0;
            for(int i = rows - 1; i >= 0; i--) // right to left
            {
                for(int j = 0; j < columns; j++) // up to down
                {
                    Stack thisStack = ship.GetStack(rowUp, j);

                    Button button = new Button();
                    button.Location = new Point((buttonWidth + 4) * i + minX, (buttonHeight + 4) * j + minY);
                    button.Name = $"containerButton:{rowUp}-{j}";
                    button.Size = new Size(buttonWidth, buttonHeight);

                    if(thisStack != null)
                    {
                        button.Text = thisStack.weight + " kg";
                    }
                    else
                    {
                        button.Text = "x0 kg";
                    }
                    
                    button.UseVisualStyleBackColor = true;
                    button.Click += new EventHandler(stackButtonClick);
                    button.TabIndex = tabIndex;
                    button.UseVisualStyleBackColor = true;
                    buttons.Add(button);

                    Controls.Add(button);

                    tabIndex++;
                }
                rowUp++;
            }
        }

        private void loadEditContainerGroupBox(int weight, bool valuable)
        {
            editContainerWeightNumeric.Value = weight;
            editContainerGroupBox.Enabled = true;
        }

        private void unloadEditContainerGroupBox()
        {
            editContainerWeightNumeric.Value = 10000;
            editContainerGroupBox.Enabled = false;
        }

        private void stackButtonClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                unloadEditContainerGroupBox();

                Button button = (Button)sender;
                string stackLocation = button.Name.Split(':')[1];
                string[] stackCoords = stackLocation.Split('-');

                int x = int.Parse(stackCoords[0]);
                int y = int.Parse(stackCoords[1]);

                Stack stack = ship.GetStack(x, y);
                ShowStack(stack);
                shownStack = stack;
            }
        }

        private void UpdateContainerWeight(int weight)
        {
            shownContainer.weight = weight;
        }

        private void UpdateContainerValuable(bool valuable)
        {
            shownContainer.valuable = valuable;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShipOverviewForm_Load(object sender, EventArgs e)
        {

        }

        private void ShowStack(Stack stack)
        {
            if(stack != null)
            {
                int minX = Size.Width - 120;
                int maxX = Size.Width - 20;
                int minY = 50;
                int maxY = Size.Height - 200;

                int buttonWidth = maxX - minX;
                int buttonHeight = maxY - minY;

                IReadOnlyList<ContainerVervoerLibrary.IContainer> baseContainers = stack.GetContainers();
                for (int i = 0; i < 10; i++)
                {
                    Button containerButton = containerStackButtons[i];
                    if (i < baseContainers.Count)
                    {
                        ContainerVervoerLibrary.IContainer baseContainer = baseContainers[i];
                        containerButton.Enabled = true;
                        string valuableadd = "!";
                        if (baseContainer.valuable)
                        {
                            valuableadd += "VAL ";
                        }
                        if(baseContainer is CooledContainer)
                        {
                            valuableadd += "CLD ";
                        }
                        containerButton.Text = $"{valuableadd}{baseContainer.GetType().Name}\n{baseContainer.weight} kg";
                    }
                    else
                    {
                        containerButton.Enabled = false;
                        containerButton.Text = "";
                    }
                }
            }
        }

        private void addContainerButton_Click(object sender, EventArgs e)
        {
            bool valuable = valuableCheckBox.Checked;
            bool cooled = cooledCheckBox.Checked;
            int weight = (int) containerWeightNumeric.Value;

            BaseContainer container;
            if (!cooled)
            {
                container = new DryContainer(ship.minContainerWeight, ship.maxContainerWeight, 120000, valuable);
            }
            else
            {
                container = new CooledContainer(ship.minContainerWeight, ship.maxContainerWeight, 120000, valuable);
            }

            container.weight = weight;

            bool loaded = ship.AddContainer(container);
            if (!loaded)
            {
                MessageBox.Show("This container can\'t be loaded on this ship");
            }
            else
            {
                //valuableCheckBox.Checked = false;
                //containerWeightNumeric.Value = 30000;
                ship.RefreshContainers();
                RefreshStackButtons(ship, buttons);
                UpdateWeightText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void containersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void shipWeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RefreshShip()
        {
            RefreshStackButtons(ship, buttons);
            ShowStack(shownStack);
        }

        private void editValuableCheckBox_AppearanceChanged(object sender, EventArgs e)
        {
            if(sender is CheckBox)
            {
                CheckBox checkBox = (CheckBox)sender;
                UpdateContainerValuable(checkBox.Checked);
                RefreshShip();
            }
        }

        private void editContainerWeightNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown)
            {
                NumericUpDown numeric = (NumericUpDown)sender;
                UpdateContainerWeight((int)numeric.Value);
                RefreshShip();
            }
        }
    }
}
