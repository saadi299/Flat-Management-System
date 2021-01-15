using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatManagementSystem
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Owner ow = new Owner();
            ow.Show();
        }
    }
}
