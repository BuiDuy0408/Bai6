using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using Entities;

namespace UILayer
{
    public partial class PosSystem : Form
    {
        PosBusiness _pos = new PosBusiness();
        Product _product = new Product();
        static List<Product> list = new List<Product>();
        private double sum;
        LoginForm log = new LoginForm();        
        public PosSystem()
        {
            InitializeComponent();
            dataGridView1.Columns.Add(_product.id, "Code");
            dataGridView1.Columns.Add(_product.name, "Description");
            dataGridView1.Columns.Add(_product.quantities.ToString(), "Quantity");
            dataGridView1.Columns.Add(_product.sell_price.ToString(), "Unit Price");
            dataGridView1.Columns.Add(_product.discount.ToString(), "Discount");
            dataGridView1.Columns.Add(_product.totalprice.ToString(), "Total Price");
            timer_Now.Start();
        }
        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            log.Show();
        }

        private void timer_Now_Tick(object sender, EventArgs e)
        {
            labelClock.Text = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                string[] divide = tBoxCode.Text.Split('-');
                string tableValue = divide[0];
                string productValue = divide[1];
                _product = _pos.GetProduct(productValue, _product);
                textBoxProductCode.Text = tBoxCode.Text;
                textBoxName.Text = _product.name;
                textBoxUnitPrice.Text = _product.sell_price.ToString();
                tBoxCode.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show("No input was given.", "Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }

        }
    }
}
