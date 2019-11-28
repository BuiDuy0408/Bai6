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
    }
}
