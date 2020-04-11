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
    public partial class Form1 : Form
    {
        OrderService service;
        public Form1()
        {
            InitializeComponent();
            service = new OrderService();
        }

        ~Form1()
        {
            service.Export("orders.xml");
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                service.Import("orders.xml");
                List<OrderTableView> views = service.Orders.Select(order => new OrderTableView(order)).ToList();
                orderBindingSource.DataSource = views;
                service.OrderIDCounter = service.Orders != null && service.Orders.Count > 0
                ? service.Orders[service.Orders.Count - 1].OrderID : 0;
                TipForm tipForm = new TipForm("Import successful!");
                tipForm.ShowDialog();
            }
            catch(Exception y)
            {
                TipForm tipForm = new TipForm(y.Message);
                tipForm.ShowDialog();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                service.Export("orders.xml");
                TipForm tipForm = new TipForm("Export successful!");
                tipForm.ShowDialog();
            }
            catch
            {
                TipForm tipForm = new TipForm("Export failed!");
                tipForm.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSearch.SelectedIndex = 0;
            importToolStripMenuItem_Click(this, null);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addOrderForm = new OrderForm(service, true, new Order(0, new Customer(), DateTime.Now, new List<OrderItem>()));
            addOrderForm.ShowDialog();
            List<OrderTableView> views = service.Orders.Select(order => new OrderTableView(order)).ToList();
            orderBindingSource.DataSource = views;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Order> resultOrders = null;
            switch(cmbSearch.SelectedIndex)
            {
                case 0:
                    if(tbxSearch.Text == "")
                    {
                        resultOrders = service.FindOrder(int.MinValue, null, null);
                    }
                    else
                    {
                        int ID;
                        try
                        {
                            ID = int.Parse(tbxSearch.Text);
                            resultOrders = service.FindOrder(ID, null, null);
                        }
                        catch
                        {
                            TipForm tipForm = new TipForm("Invaild input!");
                            tipForm.ShowDialog();
                            tbxSearch.Text = "";
                            return;
                        }
                    }
                    break;
                case 1:
                    resultOrders = service.FindOrder(int.MinValue, tbxSearch.Text, null);
                    break;
                case 2:
                    resultOrders = service.FindOrder(int.MinValue, null, tbxSearch.Text);
                    break;
            }
            List<OrderTableView> views = resultOrders.Select(order => new OrderTableView(order)).ToList();
            orderBindingSource.DataSource = views;
        }

        private void alterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = service.FindOrder((orderBindingSource.Current as OrderTableView).OrderID, null, null).ToArray()[0];
            Form alterOrderForm = new OrderForm(service, false, order);
            alterOrderForm.ShowDialog();
            List<OrderTableView> views = service.Orders.Select(o => new OrderTableView(o)).ToList();
            orderBindingSource.DataSource = views;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service.DeleteOrder((orderBindingSource.Current as OrderTableView).OrderID);
            List<OrderTableView> views = service.Orders.Select(order => new OrderTableView(order)).ToList();
            orderBindingSource.DataSource = views;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            exportToolStripMenuItem_Click(this, null);
        }
    }
}
