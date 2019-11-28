using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class UserControlForm : Form
    {
        DataTable dt = new DataTable();
        EmployeeBusiness _employeeBusiness = new EmployeeBusiness();
        string name;
        public UserControlForm()
        {
            InitializeComponent();
        }
    }
}
