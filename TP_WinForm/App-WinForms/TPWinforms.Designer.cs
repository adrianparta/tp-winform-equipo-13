﻿namespace App_WinForms
{
    partial class TPWinforms
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.buttonViewDetails = new System.Windows.Forms.Button();
            this.buttonBrandWindow = new System.Windows.Forms.Button();
            this.buttonCategoryWindow = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.numPriceMin = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.numPriceMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMax)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(472, 38);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(160, 24);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.FilterEvent);
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(668, 37);
            this.cbBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(160, 24);
            this.cbBrand.TabIndex = 1;
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.FilterEvent);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(52, 130);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(924, 336);
            this.dgvItems.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(228, 39);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.FilterEvent);
            // 
            // buttonViewDetails
            // 
            this.buttonViewDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewDetails.Location = new System.Drawing.Point(1021, 96);
            this.buttonViewDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonViewDetails.Name = "buttonViewDetails";
            this.buttonViewDetails.Size = new System.Drawing.Size(136, 31);
            this.buttonViewDetails.TabIndex = 5;
            this.buttonViewDetails.Text = "Ver Detalles";
            this.buttonViewDetails.UseVisualStyleBackColor = true;
            this.buttonViewDetails.Click += new System.EventHandler(this.buttonViewDetails_Click);
            // 
            // buttonBrandWindow
            // 
            this.buttonBrandWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBrandWindow.Location = new System.Drawing.Point(52, 485);
            this.buttonBrandWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBrandWindow.Name = "buttonBrandWindow";
            this.buttonBrandWindow.Size = new System.Drawing.Size(152, 31);
            this.buttonBrandWindow.TabIndex = 6;
            this.buttonBrandWindow.Text = "Gestionar Marcas";
            this.buttonBrandWindow.UseVisualStyleBackColor = true;
            this.buttonBrandWindow.Click += new System.EventHandler(this.buttonBrandWindow_Click);
            // 
            // buttonCategoryWindow
            // 
            this.buttonCategoryWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCategoryWindow.Location = new System.Drawing.Point(244, 485);
            this.buttonCategoryWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCategoryWindow.Name = "buttonCategoryWindow";
            this.buttonCategoryWindow.Size = new System.Drawing.Size(161, 31);
            this.buttonCategoryWindow.TabIndex = 7;
            this.buttonCategoryWindow.Text = "Gestionar Categorías";
            this.buttonCategoryWindow.UseVisualStyleBackColor = true;
            this.buttonCategoryWindow.Click += new System.EventHandler(this.buttonCategoryWindow_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteItem.Location = new System.Drawing.Point(1021, 169);
            this.buttonDeleteItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(136, 31);
            this.buttonDeleteItem.TabIndex = 8;
            this.buttonDeleteItem.Text = "Eliminar";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddItem.Location = new System.Drawing.Point(1021, 242);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(136, 31);
            this.buttonAddItem.TabIndex = 9;
            this.buttonAddItem.Text = "Añadir Producto";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(469, 18);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(66, 16);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Categoria";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(665, 18);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(45, 16);
            this.lblBrand.TabIndex = 11;
            this.lblBrand.Text = "Marca";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(225, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(59, 18);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(51, 16);
            this.lblCode.TabIndex = 13;
            this.lblCode.Text = "Codigo";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(59, 71);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 16);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Descripcion";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(61, 38);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(121, 22);
            this.txtCode.TabIndex = 15;
            this.txtCode.TextChanged += new System.EventHandler(this.FilterEvent);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(61, 91);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(359, 22);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.TextChanged += new System.EventHandler(this.FilterEvent);
            // 
            // numPriceMin
            // 
            this.numPriceMin.Location = new System.Drawing.Point(507, 94);
            this.numPriceMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPriceMin.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPriceMin.Name = "numPriceMin";
            this.numPriceMin.Size = new System.Drawing.Size(120, 22);
            this.numPriceMin.TabIndex = 17;
            this.numPriceMin.ValueChanged += new System.EventHandler(this.FilterEvent);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(472, 71);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 16);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Precio";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(472, 96);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(28, 16);
            this.lblMin.TabIndex = 19;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(665, 96);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(32, 16);
            this.lblMax.TabIndex = 20;
            this.lblMax.Text = "Max";
            // 
            // numPriceMax
            // 
            this.numPriceMax.Location = new System.Drawing.Point(708, 94);
            this.numPriceMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPriceMax.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPriceMax.Name = "numPriceMax";
            this.numPriceMax.Size = new System.Drawing.Size(120, 22);
            this.numPriceMax.TabIndex = 21;
            this.numPriceMax.ValueChanged += new System.EventHandler(this.FilterEvent);
            this.numPriceMax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numPriceMax_KeyUp);
            // 
            // TPWinforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 537);
            this.Controls.Add(this.numPriceMax);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPriceMin);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonCategoryWindow);
            this.Controls.Add(this.buttonBrandWindow);
            this.Controls.Add(this.buttonViewDetails);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.cbCategory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1237, 574);
            this.Name = "TPWinforms";
            this.Text = "TPWinforms";
            this.Activated += new System.EventHandler(this.TPWinforms_Activated);
            this.Load += new System.EventHandler(this.TPWinforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button buttonViewDetails;
        private System.Windows.Forms.Button buttonBrandWindow;
        private System.Windows.Forms.Button buttonCategoryWindow;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown numPriceMin;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown numPriceMax;
    }
}

