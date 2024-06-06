namespace Cataloguer
{
    partial class WareHouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.AvtorPanel = new System.Windows.Forms.Panel();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.SecurityCheckBox = new System.Windows.Forms.CheckBox();
            this.QuantityCheckBox = new System.Windows.Forms.CheckBox();
            this.ManufCheckBox = new System.Windows.Forms.CheckBox();
            this.PriceCheckBox = new System.Windows.Forms.CheckBox();
            this.SizeCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AvtPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AvtorPanel.SuspendLayout();
            this.GroupBox.SuspendLayout();
            this.AvtPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(20, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 288);
            this.dataGridView1.TabIndex = 25;
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
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchLabel.Location = new System.Drawing.Point(20, 31);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(164, 25);
            this.SearchLabel.TabIndex = 26;
            this.SearchLabel.Text = "Поиск товара:";
            // 
            // SearchField
            // 
            this.SearchField.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchField.Location = new System.Drawing.Point(203, 31);
            this.SearchField.Multiline = true;
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(369, 34);
            this.SearchField.TabIndex = 27;
            this.SearchField.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            this.SearchField.Enter += new System.EventHandler(this.SearchText_Enter);
            this.SearchField.Leave += new System.EventHandler(this.SearchText_Leave);
            // 
            // AvtorPanel
            // 
            this.AvtorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(57)))), ((int)(((byte)(30)))));
            this.AvtorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AvtorPanel.Controls.Add(this.GroupBox);
            this.AvtorPanel.Controls.Add(this.label2);
            this.AvtorPanel.Controls.Add(this.SearchField);
            this.AvtorPanel.Controls.Add(this.SearchLabel);
            this.AvtorPanel.Controls.Add(this.dataGridView1);
            this.AvtorPanel.Location = new System.Drawing.Point(-2, 178);
            this.AvtorPanel.Name = "AvtorPanel";
            this.AvtorPanel.Size = new System.Drawing.Size(1251, 602);
            this.AvtorPanel.TabIndex = 23;
            this.AvtorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AvtorPanel_MouseDown);
            this.AvtorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AvtorPanel_MouseMove);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.NameCheckBox);
            this.GroupBox.Controls.Add(this.SecurityCheckBox);
            this.GroupBox.Controls.Add(this.QuantityCheckBox);
            this.GroupBox.Controls.Add(this.ManufCheckBox);
            this.GroupBox.Controls.Add(this.PriceCheckBox);
            this.GroupBox.Controls.Add(this.SizeCheckBox);
            this.GroupBox.Location = new System.Drawing.Point(605, 59);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(238, 309);
            this.GroupBox.TabIndex = 34;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = " ";
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.NameCheckBox.Location = new System.Drawing.Point(6, 21);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(141, 29);
            this.NameCheckBox.TabIndex = 34;
            this.NameCheckBox.Text = "Названию";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // SecurityCheckBox
            // 
            this.SecurityCheckBox.AutoSize = true;
            this.SecurityCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecurityCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SecurityCheckBox.Location = new System.Drawing.Point(6, 271);
            this.SecurityCheckBox.Name = "SecurityCheckBox";
            this.SecurityCheckBox.Size = new System.Drawing.Size(203, 29);
            this.SecurityCheckBox.TabIndex = 33;
            this.SecurityCheckBox.Text = "Сроку гарантии";
            this.SecurityCheckBox.UseVisualStyleBackColor = true;
            // 
            // QuantityCheckBox
            // 
            this.QuantityCheckBox.AutoSize = true;
            this.QuantityCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.QuantityCheckBox.Location = new System.Drawing.Point(6, 71);
            this.QuantityCheckBox.Name = "QuantityCheckBox";
            this.QuantityCheckBox.Size = new System.Drawing.Size(156, 29);
            this.QuantityCheckBox.TabIndex = 29;
            this.QuantityCheckBox.Text = "Количеству";
            this.QuantityCheckBox.UseVisualStyleBackColor = true;
            // 
            // ManufCheckBox
            // 
            this.ManufCheckBox.AutoSize = true;
            this.ManufCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ManufCheckBox.Location = new System.Drawing.Point(6, 121);
            this.ManufCheckBox.Name = "ManufCheckBox";
            this.ManufCheckBox.Size = new System.Drawing.Size(200, 29);
            this.ManufCheckBox.TabIndex = 30;
            this.ManufCheckBox.Text = "Производителю";
            this.ManufCheckBox.UseVisualStyleBackColor = true;
            // 
            // PriceCheckBox
            // 
            this.PriceCheckBox.AutoSize = true;
            this.PriceCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.PriceCheckBox.Location = new System.Drawing.Point(6, 218);
            this.PriceCheckBox.Name = "PriceCheckBox";
            this.PriceCheckBox.Size = new System.Drawing.Size(87, 29);
            this.PriceCheckBox.TabIndex = 32;
            this.PriceCheckBox.Text = "Цене";
            this.PriceCheckBox.UseVisualStyleBackColor = true;
            // 
            // SizeCheckBox
            // 
            this.SizeCheckBox.AutoSize = true;
            this.SizeCheckBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SizeCheckBox.Location = new System.Drawing.Point(6, 168);
            this.SizeCheckBox.Name = "SizeCheckBox";
            this.SizeCheckBox.Size = new System.Drawing.Size(121, 29);
            this.SizeCheckBox.TabIndex = 31;
            this.SizeCheckBox.Text = "Размеру";
            this.SizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(600, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Сортировать по:";
            // 
            // AvtPanel
            // 
            this.AvtPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(131)))));
            this.AvtPanel.Controls.Add(this.CloseButton);
            this.AvtPanel.Controls.Add(this.label1);
            this.AvtPanel.Location = new System.Drawing.Point(-2, 1);
            this.AvtPanel.Name = "AvtPanel";
            this.AvtPanel.Size = new System.Drawing.Size(1251, 183);
            this.AvtPanel.TabIndex = 24;
            this.AvtPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AvtPanel_MouseDown);
            this.AvtPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AvtPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(1205, -12);
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
            this.label1.Location = new System.Drawing.Point(420, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Склад товаров";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WareHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 777);
            this.Controls.Add(this.AvtPanel);
            this.Controls.Add(this.AvtorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WareHouseForm";
            this.Text = "WareHouseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AvtorPanel.ResumeLayout(false);
            this.AvtorPanel.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.AvtPanel.ResumeLayout(false);
            this.AvtPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Panel AvtorPanel;
        private System.Windows.Forms.Panel AvtPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.CheckBox SecurityCheckBox;
        private System.Windows.Forms.CheckBox PriceCheckBox;
        private System.Windows.Forms.CheckBox QuantityCheckBox;
        private System.Windows.Forms.CheckBox SizeCheckBox;
        private System.Windows.Forms.CheckBox ManufCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.CheckBox NameCheckBox;
    }
}