namespace OrderManagementWindows
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.tlpOrder = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txbCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblOrderTime = new System.Windows.Forms.Label();
            this.dtpOrderTime = new System.Windows.Forms.DateTimePicker();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tlpItem = new System.Windows.Forms.TableLayoutPanel();
            this.lblGoodsID = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbGoodsID = new System.Windows.Forms.ComboBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.pnlItemList = new System.Windows.Forms.Panel();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpOrder.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.tlpItem.SuspendLayout();
            this.pnlItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.cmsItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpOrder
            // 
            this.tlpOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpOrder.ColumnCount = 2;
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.15942F));
            this.tlpOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.84058F));
            this.tlpOrder.Controls.Add(this.lblCustomerName, 0, 0);
            this.tlpOrder.Controls.Add(this.txbCustomerName, 1, 0);
            this.tlpOrder.Controls.Add(this.lblCustomerAddress, 0, 1);
            this.tlpOrder.Controls.Add(this.txbCustomerAddress, 1, 1);
            this.tlpOrder.Controls.Add(this.lblOrderTime, 0, 2);
            this.tlpOrder.Controls.Add(this.dtpOrderTime, 1, 2);
            this.tlpOrder.Location = new System.Drawing.Point(212, 12);
            this.tlpOrder.Name = "tlpOrder";
            this.tlpOrder.RowCount = 3;
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpOrder.Size = new System.Drawing.Size(345, 142);
            this.tlpOrder.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(15, 17);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(111, 15);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer name";
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCustomerName.Location = new System.Drawing.Point(144, 12);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(198, 25);
            this.txbCustomerName.TabIndex = 1;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(3, 65);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(135, 15);
            this.lblCustomerAddress.TabIndex = 2;
            this.lblCustomerAddress.Text = "Customer address";
            // 
            // txbCustomerAddress
            // 
            this.txbCustomerAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCustomerAddress.Location = new System.Drawing.Point(144, 60);
            this.txbCustomerAddress.Name = "txbCustomerAddress";
            this.txbCustomerAddress.Size = new System.Drawing.Size(198, 25);
            this.txbCustomerAddress.TabIndex = 3;
            // 
            // lblOrderTime
            // 
            this.lblOrderTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderTime.AutoSize = true;
            this.lblOrderTime.Location = new System.Drawing.Point(27, 111);
            this.lblOrderTime.Name = "lblOrderTime";
            this.lblOrderTime.Size = new System.Drawing.Size(87, 15);
            this.lblOrderTime.TabIndex = 4;
            this.lblOrderTime.Text = "Order time";
            // 
            // dtpOrderTime
            // 
            this.dtpOrderTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpOrderTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtpOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderTime.Location = new System.Drawing.Point(144, 106);
            this.dtpOrderTime.MinDate = new System.DateTime(1840, 1, 1, 0, 0, 0, 0);
            this.dtpOrderTime.Name = "dtpOrderTime";
            this.dtpOrderTime.ShowUpDown = true;
            this.dtpOrderTime.Size = new System.Drawing.Size(198, 25);
            this.dtpOrderTime.TabIndex = 5;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.lblOrderID);
            this.pnlOrder.Controls.Add(this.btnAddOrder);
            this.pnlOrder.Controls.Add(this.tlpOrder);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(751, 191);
            this.pnlOrder.TabIndex = 2;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(13, 13);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(0, 15);
            this.lblOrderID.TabIndex = 2;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddOrder.Location = new System.Drawing.Point(334, 160);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(107, 23);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Add order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.btnAddItem);
            this.pnlItem.Controls.Add(this.tlpItem);
            this.pnlItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlItem.Location = new System.Drawing.Point(413, 191);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(338, 227);
            this.pnlItem.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddItem.Location = new System.Drawing.Point(127, 129);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(91, 23);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tlpItem
            // 
            this.tlpItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpItem.ColumnCount = 2;
            this.tlpItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.65704F));
            this.tlpItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.34296F));
            this.tlpItem.Controls.Add(this.lblGoodsID, 0, 0);
            this.tlpItem.Controls.Add(this.lblQuantity, 0, 1);
            this.tlpItem.Controls.Add(this.cmbGoodsID, 1, 0);
            this.tlpItem.Controls.Add(this.txbQuantity, 1, 1);
            this.tlpItem.Location = new System.Drawing.Point(36, 23);
            this.tlpItem.Name = "tlpItem";
            this.tlpItem.RowCount = 2;
            this.tlpItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpItem.Size = new System.Drawing.Size(277, 86);
            this.tlpItem.TabIndex = 0;
            // 
            // lblGoodsID
            // 
            this.lblGoodsID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGoodsID.AutoSize = true;
            this.lblGoodsID.Location = new System.Drawing.Point(12, 14);
            this.lblGoodsID.Name = "lblGoodsID";
            this.lblGoodsID.Size = new System.Drawing.Size(71, 15);
            this.lblGoodsID.TabIndex = 0;
            this.lblGoodsID.Text = "Goods ID";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 57);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 15);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmbGoodsID
            // 
            this.cmbGoodsID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGoodsID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGoodsID.FormattingEnabled = true;
            this.cmbGoodsID.Location = new System.Drawing.Point(107, 10);
            this.cmbGoodsID.Name = "cmbGoodsID";
            this.cmbGoodsID.Size = new System.Drawing.Size(157, 23);
            this.cmbGoodsID.TabIndex = 2;
            // 
            // txbQuantity
            // 
            this.txbQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbQuantity.Location = new System.Drawing.Point(108, 52);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(156, 25);
            this.txbQuantity.TabIndex = 3;
            // 
            // pnlItemList
            // 
            this.pnlItemList.Controls.Add(this.dgvItemList);
            this.pnlItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItemList.Location = new System.Drawing.Point(0, 191);
            this.pnlItemList.Name = "pnlItemList";
            this.pnlItemList.Size = new System.Drawing.Size(413, 227);
            this.pnlItemList.TabIndex = 4;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AutoGenerateColumns = false;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIDDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvItemList.ContextMenuStrip = this.cmsItem;
            this.dgvItemList.DataSource = this.orderItemBindingSource;
            this.dgvItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemList.Location = new System.Drawing.Point(0, 0);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RowHeadersWidth = 51;
            this.dgvItemList.RowTemplate.Height = 27;
            this.dgvItemList.Size = new System.Drawing.Size(413, 227);
            this.dgvItemList.TabIndex = 0;
            // 
            // goodsIDDataGridViewTextBoxColumn
            // 
            this.goodsIDDataGridViewTextBoxColumn.DataPropertyName = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.goodsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsIDDataGridViewTextBoxColumn.Name = "goodsIDDataGridViewTextBoxColumn";
            this.goodsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.goodsNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsPriceDataGridViewTextBoxColumn
            // 
            this.goodsPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodsPrice";
            this.goodsPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.goodsPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsPriceDataGridViewTextBoxColumn.Name = "goodsPriceDataGridViewTextBoxColumn";
            this.goodsPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsPriceDataGridViewTextBoxColumn.Width = 75;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 75;
            // 
            // cmsItem
            // 
            this.cmsItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsItem.Name = "cmsItem";
            this.cmsItem.Size = new System.Drawing.Size(211, 56);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(OrderManagement.OrderItem);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 418);
            this.Controls.Add(this.pnlItemList);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.pnlOrder);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tlpOrder.ResumeLayout(false);
            this.tlpOrder.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.tlpItem.ResumeLayout(false);
            this.tlpItem.PerformLayout();
            this.pnlItemList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.cmsItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOrder;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txbCustomerAddress;
        private System.Windows.Forms.Label lblOrderTime;
        private System.Windows.Forms.DateTimePicker dtpOrderTime;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Panel pnlItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TableLayoutPanel tlpItem;
        private System.Windows.Forms.Label lblGoodsID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbGoodsID;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Panel pnlItemList;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.ContextMenuStrip cmsItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}