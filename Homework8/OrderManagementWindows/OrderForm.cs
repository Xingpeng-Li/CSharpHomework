using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;

namespace OrderManagementWindows
{
    public partial class OrderForm : Form
    {
        bool isAdd;  //表示是否是添加一个订单
        OrderService service;
        Order order;
        OrderItem item;
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(OrderService service,bool isAdd,Order order)
        {
            InitializeComponent();
            this.isAdd = isAdd;
            this.service = service;
            this.order = order;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            txbCustomerName.DataBindings.Add("Text", order.Customer, "Name");
            txbCustomerAddress.DataBindings.Add("Text", order.Customer, "Address");
            dtpOrderTime.DataBindings.Add("Value", order, "OrderTime");
            foreach (int ID in GoodsDic.GoodsDictionary.Keys) cmbGoodsID.Items.Add(ID);
            cmbGoodsID.Text = "1";
            item = new OrderItem(new Goods(1), 0);
            cmbGoodsID.DataBindings.Add("Text", item.ThisGoods, "GoodsID");
            txbQuantity.DataBindings.Add("Text", item, "Quantity");
            if(!isAdd)
            {
                if(order.OrderItems != null)
                {
                    orderItemBindingSource.DataSource = order.OrderItems;
                }
                lblOrderID.Text = "Order ID:" + order.OrderID.ToString();
                btnAddOrder.Visible = false;
            }
            else
            {
                btnAddItem.Visible = false;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            service.AddOrder(order);
            lblOrderID.Text = "Order ID:" + order.OrderID.ToString();
            btnAddItem.Visible = true;
            btnAddOrder.Visible = false;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            service.AlterOrder(order.OrderID, "add item", new OrderItem(new Goods(item.ThisGoods.GoodsID),item.Quantity));
            orderItemBindingSource.DataSource = order.OrderItems;
            orderItemBindingSource.ResetBindings(false);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service.AlterOrder(order.OrderID, "delete item", null, (orderItemBindingSource.Current as OrderItem).GoodsID);
            orderItemBindingSource.ResetBindings(false);
        }
    }
}
