namespace ContainerVervoerWFA
{
    partial class ShipOverviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.cooledRadioButton = new System.Windows.Forms.RadioButton();
            this.valuableRadioButton = new System.Windows.Forms.RadioButton();
            this.loadKgLabel = new System.Windows.Forms.Label();
            this.addContainerButton = new System.Windows.Forms.Button();
            this.containerWeightLabel = new System.Windows.Forms.Label();
            this.containerWeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.overviewTitleLabel = new System.Windows.Forms.Label();
            this.shipWeightLabel = new System.Windows.Forms.Label();
            this.voorkantLabel = new System.Windows.Forms.Label();
            this.achterkantLabel = new System.Windows.Forms.Label();
            this.editContainerGroupBox = new System.Windows.Forms.GroupBox();
            this.editContainerKgLabel = new System.Windows.Forms.Label();
            this.editContainerWeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.defaultRadioButton = new System.Windows.Forms.RadioButton();
            this.propertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerWeightNumeric)).BeginInit();
            this.editContainerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editContainerWeightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Location = new System.Drawing.Point(9, 566);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(65, 43);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesGroupBox.Controls.Add(this.defaultRadioButton);
            this.propertiesGroupBox.Controls.Add(this.cooledRadioButton);
            this.propertiesGroupBox.Controls.Add(this.valuableRadioButton);
            this.propertiesGroupBox.Controls.Add(this.loadKgLabel);
            this.propertiesGroupBox.Controls.Add(this.addContainerButton);
            this.propertiesGroupBox.Controls.Add(this.containerWeightLabel);
            this.propertiesGroupBox.Controls.Add(this.containerWeightNumeric);
            this.propertiesGroupBox.Location = new System.Drawing.Point(79, 566);
            this.propertiesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.propertiesGroupBox.Size = new System.Drawing.Size(766, 43);
            this.propertiesGroupBox.TabIndex = 3;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Properties";
            // 
            // cooledRadioButton
            // 
            this.cooledRadioButton.AutoSize = true;
            this.cooledRadioButton.Location = new System.Drawing.Point(306, 18);
            this.cooledRadioButton.Name = "cooledRadioButton";
            this.cooledRadioButton.Size = new System.Drawing.Size(58, 17);
            this.cooledRadioButton.TabIndex = 7;
            this.cooledRadioButton.TabStop = true;
            this.cooledRadioButton.Text = "Cooled";
            this.cooledRadioButton.UseVisualStyleBackColor = true;
            // 
            // valuableRadioButton
            // 
            this.valuableRadioButton.AutoSize = true;
            this.valuableRadioButton.Location = new System.Drawing.Point(234, 18);
            this.valuableRadioButton.Name = "valuableRadioButton";
            this.valuableRadioButton.Size = new System.Drawing.Size(66, 17);
            this.valuableRadioButton.TabIndex = 6;
            this.valuableRadioButton.TabStop = true;
            this.valuableRadioButton.Text = "Valuable";
            this.valuableRadioButton.UseVisualStyleBackColor = true;
            // 
            // loadKgLabel
            // 
            this.loadKgLabel.AutoSize = true;
            this.loadKgLabel.Location = new System.Drawing.Point(136, 19);
            this.loadKgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadKgLabel.Name = "loadKgLabel";
            this.loadKgLabel.Size = new System.Drawing.Size(19, 13);
            this.loadKgLabel.TabIndex = 5;
            this.loadKgLabel.Text = "kg";
            // 
            // addContainerButton
            // 
            this.addContainerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addContainerButton.Location = new System.Drawing.Point(705, 11);
            this.addContainerButton.Margin = new System.Windows.Forms.Padding(2);
            this.addContainerButton.Name = "addContainerButton";
            this.addContainerButton.Size = new System.Drawing.Size(56, 26);
            this.addContainerButton.TabIndex = 2;
            this.addContainerButton.Text = "Add";
            this.addContainerButton.UseVisualStyleBackColor = true;
            this.addContainerButton.Click += new System.EventHandler(this.AddContainerButton_Click);
            // 
            // containerWeightLabel
            // 
            this.containerWeightLabel.AutoSize = true;
            this.containerWeightLabel.Location = new System.Drawing.Point(33, 19);
            this.containerWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.containerWeightLabel.Name = "containerWeightLabel";
            this.containerWeightLabel.Size = new System.Drawing.Size(31, 13);
            this.containerWeightLabel.TabIndex = 1;
            this.containerWeightLabel.Text = "Load";
            // 
            // containerWeightNumeric
            // 
            this.containerWeightNumeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.containerWeightNumeric.Location = new System.Drawing.Point(64, 18);
            this.containerWeightNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.containerWeightNumeric.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.containerWeightNumeric.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.containerWeightNumeric.Name = "containerWeightNumeric";
            this.containerWeightNumeric.Size = new System.Drawing.Size(68, 20);
            this.containerWeightNumeric.TabIndex = 0;
            this.containerWeightNumeric.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            // 
            // overviewTitleLabel
            // 
            this.overviewTitleLabel.AutoSize = true;
            this.overviewTitleLabel.Location = new System.Drawing.Point(366, 10);
            this.overviewTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.overviewTitleLabel.Name = "overviewTitleLabel";
            this.overviewTitleLabel.Size = new System.Drawing.Size(13, 13);
            this.overviewTitleLabel.TabIndex = 4;
            this.overviewTitleLabel.Text = "[]";
            // 
            // shipWeightLabel
            // 
            this.shipWeightLabel.AutoSize = true;
            this.shipWeightLabel.Location = new System.Drawing.Point(532, 10);
            this.shipWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shipWeightLabel.Name = "shipWeightLabel";
            this.shipWeightLabel.Size = new System.Drawing.Size(13, 13);
            this.shipWeightLabel.TabIndex = 6;
            this.shipWeightLabel.Text = "[]";
            this.shipWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // voorkantLabel
            // 
            this.voorkantLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.voorkantLabel.AutoSize = true;
            this.voorkantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voorkantLabel.Location = new System.Drawing.Point(790, 10);
            this.voorkantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.voorkantLabel.Name = "voorkantLabel";
            this.voorkantLabel.Size = new System.Drawing.Size(58, 13);
            this.voorkantLabel.TabIndex = 7;
            this.voorkantLabel.Text = "Voorkant";
            // 
            // achterkantLabel
            // 
            this.achterkantLabel.AutoSize = true;
            this.achterkantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achterkantLabel.Location = new System.Drawing.Point(7, 10);
            this.achterkantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.achterkantLabel.Name = "achterkantLabel";
            this.achterkantLabel.Size = new System.Drawing.Size(69, 13);
            this.achterkantLabel.TabIndex = 8;
            this.achterkantLabel.Text = "Achterkant";
            // 
            // editContainerGroupBox
            // 
            this.editContainerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editContainerGroupBox.Controls.Add(this.editContainerKgLabel);
            this.editContainerGroupBox.Controls.Add(this.editContainerWeightNumeric);
            this.editContainerGroupBox.Enabled = false;
            this.editContainerGroupBox.Location = new System.Drawing.Point(964, 10);
            this.editContainerGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.editContainerGroupBox.Name = "editContainerGroupBox";
            this.editContainerGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.editContainerGroupBox.Size = new System.Drawing.Size(118, 59);
            this.editContainerGroupBox.TabIndex = 9;
            this.editContainerGroupBox.TabStop = false;
            this.editContainerGroupBox.Text = "Container";
            // 
            // editContainerKgLabel
            // 
            this.editContainerKgLabel.AutoSize = true;
            this.editContainerKgLabel.Location = new System.Drawing.Point(97, 26);
            this.editContainerKgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editContainerKgLabel.Name = "editContainerKgLabel";
            this.editContainerKgLabel.Size = new System.Drawing.Size(19, 13);
            this.editContainerKgLabel.TabIndex = 1;
            this.editContainerKgLabel.Text = "kg";
            // 
            // editContainerWeightNumeric
            // 
            this.editContainerWeightNumeric.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.editContainerWeightNumeric.Location = new System.Drawing.Point(4, 26);
            this.editContainerWeightNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.editContainerWeightNumeric.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.editContainerWeightNumeric.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.editContainerWeightNumeric.Name = "editContainerWeightNumeric";
            this.editContainerWeightNumeric.Size = new System.Drawing.Size(88, 20);
            this.editContainerWeightNumeric.TabIndex = 0;
            this.editContainerWeightNumeric.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.editContainerWeightNumeric.ValueChanged += new System.EventHandler(this.EditContainerWeightNumeric_ValueChanged);
            // 
            // defaultRadioButton
            // 
            this.defaultRadioButton.AutoSize = true;
            this.defaultRadioButton.Checked = true;
            this.defaultRadioButton.Location = new System.Drawing.Point(169, 18);
            this.defaultRadioButton.Name = "defaultRadioButton";
            this.defaultRadioButton.Size = new System.Drawing.Size(59, 17);
            this.defaultRadioButton.TabIndex = 8;
            this.defaultRadioButton.TabStop = true;
            this.defaultRadioButton.Text = "Default";
            this.defaultRadioButton.UseVisualStyleBackColor = true;
            // 
            // ShipOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 618);
            this.Controls.Add(this.editContainerGroupBox);
            this.Controls.Add(this.achterkantLabel);
            this.Controls.Add(this.voorkantLabel);
            this.Controls.Add(this.shipWeightLabel);
            this.Controls.Add(this.overviewTitleLabel);
            this.Controls.Add(this.propertiesGroupBox);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShipOverviewForm";
            this.Text = "Ship overview";
            this.Load += new System.EventHandler(this.ShipOverviewForm_Load);
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerWeightNumeric)).EndInit();
            this.editContainerGroupBox.ResumeLayout(false);
            this.editContainerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editContainerWeightNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.Label containerWeightLabel;
        private System.Windows.Forms.NumericUpDown containerWeightNumeric;
        private System.Windows.Forms.Button addContainerButton;
        private System.Windows.Forms.Label overviewTitleLabel;
        private System.Windows.Forms.Label shipWeightLabel;
        private System.Windows.Forms.Label voorkantLabel;
        private System.Windows.Forms.Label achterkantLabel;
        private System.Windows.Forms.GroupBox editContainerGroupBox;
        private System.Windows.Forms.NumericUpDown editContainerWeightNumeric;
        private System.Windows.Forms.Label editContainerKgLabel;
        private System.Windows.Forms.Label loadKgLabel;
        private System.Windows.Forms.RadioButton cooledRadioButton;
        private System.Windows.Forms.RadioButton valuableRadioButton;
        private System.Windows.Forms.RadioButton defaultRadioButton;
    }
}