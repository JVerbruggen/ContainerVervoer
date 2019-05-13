namespace ContainerVervoerWFA
{
    partial class NewShip
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.tonsLabel = new System.Windows.Forms.Label();
            this.maximumWeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.maximumWeightLabel = new System.Windows.Forms.Label();
            this.rowsPerShipLabel = new System.Windows.Forms.Label();
            this.stacksPerRowLabel = new System.Windows.Forms.Label();
            this.rowsPerShipNumeric = new System.Windows.Forms.NumericUpDown();
            this.stacksPerRowNumeric = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.propertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumWeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsPerShipNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stacksPerRowNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(99, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesGroupBox.Controls.Add(this.tonsLabel);
            this.propertiesGroupBox.Controls.Add(this.maximumWeightNumeric);
            this.propertiesGroupBox.Controls.Add(this.maximumWeightLabel);
            this.propertiesGroupBox.Controls.Add(this.rowsPerShipLabel);
            this.propertiesGroupBox.Controls.Add(this.stacksPerRowLabel);
            this.propertiesGroupBox.Controls.Add(this.rowsPerShipNumeric);
            this.propertiesGroupBox.Controls.Add(this.stacksPerRowNumeric);
            this.propertiesGroupBox.Controls.Add(this.nameTextBox);
            this.propertiesGroupBox.Controls.Add(this.nameLabel);
            this.propertiesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(344, 158);
            this.propertiesGroupBox.TabIndex = 1;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Properties";
            // 
            // tonsLabel
            // 
            this.tonsLabel.AutoSize = true;
            this.tonsLabel.Location = new System.Drawing.Point(235, 116);
            this.tonsLabel.Name = "tonsLabel";
            this.tonsLabel.Size = new System.Drawing.Size(35, 17);
            this.tonsLabel.TabIndex = 8;
            this.tonsLabel.Text = "tons";
            // 
            // maximumWeightNumeric
            // 
            this.maximumWeightNumeric.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maximumWeightNumeric.Location = new System.Drawing.Point(150, 114);
            this.maximumWeightNumeric.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.maximumWeightNumeric.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maximumWeightNumeric.Name = "maximumWeightNumeric";
            this.maximumWeightNumeric.Size = new System.Drawing.Size(79, 22);
            this.maximumWeightNumeric.TabIndex = 7;
            this.maximumWeightNumeric.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // maximumWeightLabel
            // 
            this.maximumWeightLabel.AutoSize = true;
            this.maximumWeightLabel.Location = new System.Drawing.Point(34, 116);
            this.maximumWeightLabel.Name = "maximumWeightLabel";
            this.maximumWeightLabel.Size = new System.Drawing.Size(110, 17);
            this.maximumWeightLabel.TabIndex = 6;
            this.maximumWeightLabel.Text = "Maximum weight";
            // 
            // rowsPerShipLabel
            // 
            this.rowsPerShipLabel.AutoSize = true;
            this.rowsPerShipLabel.Location = new System.Drawing.Point(92, 88);
            this.rowsPerShipLabel.Name = "rowsPerShipLabel";
            this.rowsPerShipLabel.Size = new System.Drawing.Size(52, 17);
            this.rowsPerShipLabel.TabIndex = 5;
            this.rowsPerShipLabel.Text = "Length";
            this.rowsPerShipLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stacksPerRowLabel
            // 
            this.stacksPerRowLabel.AutoSize = true;
            this.stacksPerRowLabel.Location = new System.Drawing.Point(100, 60);
            this.stacksPerRowLabel.Name = "stacksPerRowLabel";
            this.stacksPerRowLabel.Size = new System.Drawing.Size(44, 17);
            this.stacksPerRowLabel.TabIndex = 4;
            this.stacksPerRowLabel.Text = "Width";
            // 
            // rowsPerShipNumeric
            // 
            this.rowsPerShipNumeric.Location = new System.Drawing.Point(150, 86);
            this.rowsPerShipNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.rowsPerShipNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowsPerShipNumeric.Name = "rowsPerShipNumeric";
            this.rowsPerShipNumeric.Size = new System.Drawing.Size(120, 22);
            this.rowsPerShipNumeric.TabIndex = 3;
            this.rowsPerShipNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // stacksPerRowNumeric
            // 
            this.stacksPerRowNumeric.Location = new System.Drawing.Point(150, 58);
            this.stacksPerRowNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.stacksPerRowNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stacksPerRowNumeric.Name = "stacksPerRowNumeric";
            this.stacksPerRowNumeric.Size = new System.Drawing.Size(120, 22);
            this.stacksPerRowNumeric.TabIndex = 2;
            this.stacksPerRowNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(150, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(114, 176);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(242, 35);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(12, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 35);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 223);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.propertiesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewShip";
            this.Text = "New ship";
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumWeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsPerShipNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stacksPerRowNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.Label rowsPerShipLabel;
        private System.Windows.Forms.Label stacksPerRowLabel;
        private System.Windows.Forms.NumericUpDown rowsPerShipNumeric;
        private System.Windows.Forms.NumericUpDown stacksPerRowNumeric;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label tonsLabel;
        private System.Windows.Forms.NumericUpDown maximumWeightNumeric;
        private System.Windows.Forms.Label maximumWeightLabel;
    }
}