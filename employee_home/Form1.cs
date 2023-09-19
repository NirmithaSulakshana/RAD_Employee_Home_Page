using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBox_Click(object sender, EventArgs e)
        {

        }

        private void roust_Box_Click(object sender, EventArgs e)
        {

        }

        private void roust_Box_enter(object sender, EventArgs e)
        {
            roust_Box.BackColor = Color.Thistle;
        }

        private void roust_Box_leave(object sender, EventArgs e)
        {
            roust_Box.BackColor = Color.Transparent;
        }

        private void employeeBox_enter(object sender, EventArgs e)
        {
            employee_Box.BackColor = Color.Thistle;
        }

        private void employeeBox_leave(object sender, EventArgs e)
        {
            employee_Box.BackColor = Color.Transparent;
        }
    }
}
