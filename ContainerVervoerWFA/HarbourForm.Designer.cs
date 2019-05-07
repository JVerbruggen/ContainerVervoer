namespace ContainerVervoerWFA
{
    partial class HarbourForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.managerGroupBox = new System.Windows.Forms.GroupBox();
            this.addNewButton = new System.Windows.Forms.Button();
            this.shipBox = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.managerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(39, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(209, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Jurjen\'s harbour";
            // 
            // managerGroupBox
            // 
            this.managerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerGroupBox.Controls.Add(this.addNewButton);
            this.managerGroupBox.Controls.Add(this.shipBox);
            this.managerGroupBox.Controls.Add(this.selectButton);
            this.managerGroupBox.Location = new System.Drawing.Point(12, 95);
            this.managerGroupBox.Name = "managerGroupBox";
            this.managerGroupBox.Size = new System.Drawing.Size(377, 178);
            this.managerGroupBox.TabIndex = 1;
            this.managerGroupBox.TabStop = false;
            this.managerGroupBox.Text = "Manager";
            // 
            // addNewButton
            // 
            this.addNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewButton.Location = new System.Drawing.Point(32, 45);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(130, 117);
            this.addNewButton.TabIndex = 3;
            this.addNewButton.Text = "Add";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // shipBox
            // 
            this.shipBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipBox.FormattingEnabled = true;
            this.shipBox.ItemHeight = 16;
            this.shipBox.Location = new System.Drawing.Point(168, 45);
            this.shipBox.Name = "shipBox";
            this.shipBox.Size = new System.Drawing.Size(178, 68);
            this.shipBox.TabIndex = 2;
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.Location = new System.Drawing.Point(168, 119);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(178, 43);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // HarbourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 285);
            this.Controls.Add(this.managerGroupBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HarbourForm";
            this.Text = "Harbour";
            this.managerGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox managerGroupBox;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.ListBox shipBox;
        private System.Windows.Forms.Button selectButton;
    }
}

