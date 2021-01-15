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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string un = txtUN.Text;
            string pass = txtPass.Text;

            if (un.Equals(value: "Anmona") && pass.Equals(value: "12345"))
            {
                MessageBox.Show(text: "Login");
                Information info = new Information();
                info.Show();
                this.Hide();
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}
