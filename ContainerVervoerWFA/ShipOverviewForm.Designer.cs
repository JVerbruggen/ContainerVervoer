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
            this.loadKgLabel = new System.Windows.Forms.Label();
            this.cooledCheckBox = new System.Windows.Forms.CheckBox();
            this.valuableCheckBox = new System.Windows.Forms.CheckBox();
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
            this.propertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerWeightNumeric)).BeginInit();
            this.editContainerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editContainerWeightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Location = new System.Drawing.Point(12, 696);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 53);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesGroupBox.Controls.Add(this.loadKgLabel);
            this.propertiesGroupBox.Controls.Add(this.cooledCheckBox);
            this.propertiesGroupBox.Controls.Add(this.valuableCheckBox);
            this.propertiesGroupBox.Controls.Add(this.addContainerButton);
            this.propertiesGroupBox.Controls.Add(this.containerWeightLabel);
            this.propertiesGroupBox.Controls.Add(this.containerWeightNumeric);
            this.propertiesGroupBox.Location = new System.Drawing.Point(105, 696);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(1021, 53);
            this.propertiesGroupBox.TabIndex = 3;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Properties";
            // 
            // loadKgLabel
            // 
            this.loadKgLabel.AutoSize = true;
            this.loadKgLabel.Location = new System.Drawing.Point(181, 23);
            this.loadKgLabel.Name = "loadKgLabel";
            this.loadKgLabel.Size = new System.Drawing.Size(23, 17);
            this.loadKgLabel.TabIndex = 5;
            this.loadKgLabel.Text = "kg";
            // 
            // cooledCheckBox
            // 
            this.cooledCheckBox.AutoSize = true;
            this.cooledCheckBox.Location = new System.Drawing.Point(352, 22);
            this.cooledCheckBox.Name = "cooledCheckBox";
            this.cooledCheckBox.Size = new System.Drawing.Size(74, 21);
            this.cooledCheckBox.TabIndex = 4;
            this.cooledCheckBox.Text = "Cooled";
            this.cooledCheckBox.UseVisualStyleBackColor = true;
            // 
            // valuableCheckBox
            // 
            this.valuableCheckBox.AutoSize = true;
            this.valuableCheckBox.Location = new System.Drawing.Point(251, 22);
            this.valuableCheckBox.Name = "valuableCheckBox";
            this.valuableCheckBox.Size = new System.Drawing.Size(85, 21);
            this.valuableCheckBox.TabIndex = 3;
            this.valuableCheckBox.Text = "Valuable";
            this.valuableCheckBox.UseVisualStyleBackColor = true;
            // 
            // addContainerButton
            // 
            this.addContainerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addContainerButton.Location = new System.Drawing.Point(940, 13);
            this.addContainerButton.Name = "addContainerButton";
            this.addContainerButton.Size = new System.Drawing.Size(75, 32);
            this.addContainerButton.TabIndex = 2;
            this.addContainerButton.Text = "Add";
            this.addContainerButton.UseVisualStyleBackColor = true;
            this.addContainerButton.Click += new System.EventHandler(this.AddContainerButton_Click);
            // 
            // containerWeightLabel
            // 
            this.containerWeightLabel.AutoSize = true;
            this.containerWeightLabel.Location = new System.Drawing.Point(44, 23);
            this.containerWeightLabel.Name = "containerWeightLabel";
            this.containerWeightLabel.Size = new System.Drawing.Size(40, 17);
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
            this.containerWeightNumeric.Location = new System.Drawing.Point(86, 22);
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
            this.containerWeightNumeric.Size = new System.Drawing.Size(91, 22);
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
            this.overviewTitleLabel.Location = new System.Drawing.Point(488, 12);
            this.overviewTitleLabel.Name = "overviewTitleLabel";
            this.overviewTitleLabel.Size = new System.Drawing.Size(16, 17);
            this.overviewTitleLabel.TabIndex = 4;
            this.overviewTitleLabel.Text = "[]";
            // 
            // shipWeightLabel
            // 
            this.shipWeightLabel.AutoSize = true;
            this.shipWeightLabel.Location = new System.Drawing.Point(710, 12);
            this.shipWeightLabel.Name = "shipWeightLabel";
            this.shipWeightLabel.Size = new System.Drawing.Size(16, 17);
            this.shipWeightLabel.TabIndex = 6;
            this.shipWeightLabel.Text = "[]";
            this.shipWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // voorkantLabel
            // 
            this.voorkantLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.voorkantLabel.AutoSize = true;
            this.voorkantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voorkantLabel.Location = new System.Drawing.Point(1053, 12);
            this.voorkantLabel.Name = "voorkantLabel";
            this.voorkantLabel.Size = new System.Drawing.Size(73, 17);
            this.voorkantLabel.TabIndex = 7;
            this.voorkantLabel.Text = "Voorkant";
            // 
            // achterkantLabel
            // 
            this.achterkantLabel.AutoSize = true;
            this.achterkantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achterkantLabel.Location = new System.Drawing.Point(9, 12);
            this.achterkantLabel.Name = "achterkantLabel";
            this.achterkantLabel.Size = new System.Drawing.Size(86, 17);
            this.achterkantLabel.TabIndex = 8;
            this.achterkantLabel.Text = "Achterkant";
            // 
            // editContainerGroupBox
            // 
            this.editContainerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editContainerGroupBox.Controls.Add(this.editContainerKgLabel);
            this.editContainerGroupBox.Controls.Add(this.editContainerWeightNumeric);
            this.editContainerGroupBox.Enabled = false;
            this.editContainerGroupBox.Location = new System.Drawing.Point(1286, 12);
            this.editContainerGroupBox.Name = "editContainerGroupBox";
            this.editContainerGroupBox.Size = new System.Drawing.Size(158, 73);
            this.editContainerGroupBox.TabIndex = 9;
            this.editContainerGroupBox.TabStop = false;
            this.editContainerGroupBox.Text = "Container";
            // 
            // editContainerKgLabel
            // 
            this.editContainerKgLabel.AutoSize = true;
            this.editContainerKgLabel.Location = new System.Drawing.Point(129, 32);
            this.editContainerKgLabel.Name = "editContainerKgLabel";
            this.editContainerKgLabel.Size = new System.Drawing.Size(23, 17);
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
            this.editContainerWeightNumeric.Location = new System.Drawing.Point(6, 32);
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
            this.editContainerWeightNumeric.Size = new System.Drawing.Size(117, 22);
            this.editContainerWeightNumeric.TabIndex = 0;
            this.editContainerWeightNumeric.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.editContainerWeightNumeric.ValueChanged += new System.EventHandler(this.EditContainerWeightNumeric_ValueChanged);
            // 
            // ShipOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 761);
            this.Controls.Add(this.editContainerGroupBox);
            this.Controls.Add(this.achterkantLabel);
            this.Controls.Add(this.voorkantLabel);
            this.Controls.Add(this.shipWeightLabel);
            this.Controls.Add(this.overviewTitleLabel);
            this.Controls.Add(this.propertiesGroupBox);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.CheckBox valuableCheckBox;
        private System.Windows.Forms.Label shipWeightLabel;
        private System.Windows.Forms.Label voorkantLabel;
        private System.Windows.Forms.Label achterkantLabel;
        private System.Windows.Forms.GroupBox editContainerGroupBox;
        private System.Windows.Forms.NumericUpDown editContainerWeightNumeric;
        private System.Windows.Forms.Label editContainerKgLabel;
        private System.Windows.Forms.CheckBox cooledCheckBox;
        private System.Windows.Forms.Label loadKgLabel;
    }
}