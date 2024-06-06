namespace Cataloguer
{
    partial class ShoppingCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartForm));
            this.AvtorPanel = new System.Windows.Forms.Panel();
            this.ShoppingSearchField = new System.Windows.Forms.TextBox();
            this.ShoppingSearchLabel = new System.Windows.Forms.Label();
            this.ShoppingGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareHouseGridView = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WareHouseSearchField = new System.Windows.Forms.TextBox();
            this.WareHouseSearchLabel = new System.Windows.Forms.Label();
            this.AvtPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AvtorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WareHouseGridView)).BeginInit();
            this.AvtPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvtorPanel
            // 
            this.AvtorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.AvtorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AvtorPanel.Controls.Add(this.ShoppingSearchField);
            this.AvtorPanel.Controls.Add(this.ShoppingSearchLabel);
            this.AvtorPanel.Controls.Add(this.ShoppingGridView);
            this.AvtorPanel.Controls.Add(this.WareHouseGridView);
            this.AvtorPanel.Controls.Add(this.WareHouseSearchField);
            this.AvtorPanel.Controls.Add(this.WareHouseSearchLabel);
            this.AvtorPanel.Location = new System.Drawing.Point(2, 180);
            this.AvtorPanel.Name = "AvtorPanel";
            this.AvtorPanel.Size = new System.Drawing.Size(1513, 613);
            this.AvtorPanel.TabIndex = 24;
            this.AvtorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AvtorPanel_MouseDown);
            this.AvtorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AvtorPanel_MouseMove);
            // 
            // ShoppingSearchField
            // 
            this.ShoppingSearchField.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShoppingSearchField.Location = new System.Drawing.Point(766, 31);
            this.ShoppingSearchField.Multiline = true;
            this.ShoppingSearchField.Name = "ShoppingSearchField";
            this.ShoppingSearchField.Size = new System.Drawing.Size(369, 34);
            this.ShoppingSearchField.TabIndex = 36;
            this.ShoppingSearchField.TextChanged += new System.EventHandler(this.ShoppingSearchField_TextChanged);
            this.ShoppingSearchField.Enter += new System.EventHandler(this.ShoppingSearchField_Enter);
            this.ShoppingSearchField.Leave += new System.EventHandler(this.ShoppingSearchField_Leave);
            // 
            // ShoppingSearchLabel
            // 
            this.ShoppingSearchLabel.AutoSize = true;
            this.ShoppingSearchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShoppingSearchLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShoppingSearchLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ShoppingSearchLabel.Location = new System.Drawing.Point(583, 31);
            this.ShoppingSearchLabel.Name = "ShoppingSearchLabel";
            this.ShoppingSearchLabel.Size = new System.Drawing.Size(164, 25);
            this.ShoppingSearchLabel.TabIndex = 35;
            this.ShoppingSearchLabel.Text = "Поиск товара:";
            // 
            // ShoppingGridView
            // 
            this.ShoppingGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ShoppingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShoppingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ShoppingGridView.Location = new System.Drawing.Point(588, 80);
            this.ShoppingGridView.Name = "ShoppingGridView";
            this.ShoppingGridView.RowHeadersWidth = 51;
            this.ShoppingGridView.RowTemplate.Height = 24;
            this.ShoppingGridView.Size = new System.Drawing.Size(552, 288);
            this.ShoppingGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Manufacture";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Size";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Security";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // WareHouseGridView
            // 
            this.WareHouseGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.WareHouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WareHouseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.WareHouseGridView.Location = new System.Drawing.Point(20, 80);
            this.WareHouseGridView.Name = "WareHouseGridView";
            this.WareHouseGridView.RowHeadersWidth = 51;
            this.WareHouseGridView.RowTemplate.Height = 24;
            this.WareHouseGridView.Size = new System.Drawing.Size(552, 288);
            this.WareHouseGridView.TabIndex = 33;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ProductName";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quantity";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Manufacture";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Size";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Security";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // WareHouseSearchField
            // 
            this.WareHouseSearchField.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WareHouseSearchField.Location = new System.Drawing.Point(203, 31);
            this.WareHouseSearchField.Multiline = true;
            this.WareHouseSearchField.Name = "WareHouseSearchField";
            this.WareHouseSearchField.Size = new System.Drawing.Size(369, 34);
            this.WareHouseSearchField.TabIndex = 27;
            this.WareHouseSearchField.TextChanged += new System.EventHandler(this.WareHouseSearchField_TextChanged);
            this.WareHouseSearchField.Enter += new System.EventHandler(this.WareHouseSearchField_Enter);
            this.WareHouseSearchField.Leave += new System.EventHandler(this.WareHouseSearchField_Leave);
            // 
            // WareHouseSearchLabel
            // 
            this.WareHouseSearchLabel.AutoSize = true;
            this.WareHouseSearchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WareHouseSearchLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WareHouseSearchLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.WareHouseSearchLabel.Location = new System.Drawing.Point(20, 31);
            this.WareHouseSearchLabel.Name = "WareHouseSearchLabel";
            this.WareHouseSearchLabel.Size = new System.Drawing.Size(164, 25);
            this.WareHouseSearchLabel.TabIndex = 26;
            this.WareHouseSearchLabel.Text = "Поиск товара:";
            // 
            // AvtPanel
            // 
            this.AvtPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(131)))));
            this.AvtPanel.Controls.Add(this.CloseButton);
            this.AvtPanel.Controls.Add(this.label1);
            this.AvtPanel.Location = new System.Drawing.Point(2, 0);
            this.AvtPanel.Name = "AvtPanel";
            this.AvtPanel.Size = new System.Drawing.Size(1513, 183);
            this.AvtPanel.TabIndex = 25;
            this.AvtPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AvtPanel_MouseDown);
            this.AvtPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AvtPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(1467, -9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(43, 49);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(580, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Корзина товаров";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 795);
            this.Controls.Add(this.AvtPanel);
            this.Controls.Add(this.AvtorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShoppingCartForm";
            this.Text = "ShoppingCartForm";
            this.AvtorPanel.ResumeLayout(false);
            this.AvtorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShoppingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WareHouseGridView)).EndInit();
            this.AvtPanel.ResumeLayout(false);
            this.AvtPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AvtorPanel;
        private System.Windows.Forms.TextBox WareHouseSearchField;
        private System.Windows.Forms.Label WareHouseSearchLabel;
        private System.Windows.Forms.Panel AvtPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.DataGridView WareHouseGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView ShoppingGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox ShoppingSearchField;
        private System.Windows.Forms.Label ShoppingSearchLabel;
    }
}