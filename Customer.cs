using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FlatManagementSystem
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            txtCage.Text = txtCcon.Text = txtCID.Text = txtCN.Text = txtSearch.Text = "";
            this.LoadCustomer();
        }
        private void LoadCustomer()
        {
            try

            {
                string query = "select *from CustomerInfo";

                if(!string.IsNullOrEmpty(txtSearch.Text))
                {
                    query = query + " where CustomerName like'%" + txtSearch.Text + "%'";
                }

                DataTable dt = DataAccess.GetDataTable(query);
                dgvCustomerInfoes.DataSource = dt;
                dgvCustomerInfoes.Refresh();
                dgvCustomerInfoes.ClearSelection();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.LoadCustomer();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void DgvCustomerInfoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string cid = dgvCustomerInfoes.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                //MessageBox.Show(cid);//
                this.LoadCustomers(cid);
            }
        }
        private void LoadCustomers(string cid)
        {
            try

            {
                string query = "select *from CustomerInfo where CustomerID="+cid;
 
                DataTable dt = DataAccess.GetDataTable(query);
                if(dt.Rows.Count !=1)
                {
                    return;
                }
                txtCID.Text = dt.Rows[0]["CustomerID"].ToString();
                txtCcon.Text = dt.Rows[0]["CustomerContact"].ToString();
                txtCage.Text = dt.Rows[0]["CustomerAge"].ToString();
                txtCN.Text = dt.Rows[0]["CustomerName"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.NewCustomer();
        }
        private void NewCustomer()
        {
            txtCage.Text = "";
            txtCcon.Text = "";
            txtCID.Text = "";
            txtCN.Text = "";
            dgvCustomerInfoes.ClearSelection();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string cn = txtCN.Text;
            string cid = txtCID.Text;
            string cage = txtCage.Text;
            string ccon = txtCcon.Text;
           
            string message = "Customer Name:" + cn + "\n"
                             + "ID:" + cid + "\n"
                             + "Customer Age:" + cage + "\n"
                             + "Customer Contact:" + ccon + "\n";
            MessageBox.Show(message);

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connectionString: "Data Source=localhost;Initial Catalog=FlatManagement;Integrated Security=True");
                con.Open();

                String query = "insert into CustomerInfo(CustomerName , CustomerContact , CustomerAge )" +
                                "values('" + cn + "', '" + ccon + "', '" + cage + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show(text: "Saved");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            finally
            {
                if (con != null)
                    con.Close();
            }


            if (txtCID.Text == "")
            {
                MessageBox.Show(text: "Insert");
            }
            else
            {
                MessageBox.Show(text: "Update");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCID.Text == "")
                {
                    MessageBox.Show(text: "Please select a Row First");
                    return;
                }
                string query = "delete from CustomerInfo where CustomerID=" + txtCID.Text;
                DataAccess.ExecuteQuery(query);
                this.LoadCustomer();
                this.NewCustomer();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
