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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            txtEage.Text = txtEcon.Text = txtEID.Text = txtEN.Text = txtSearch.Text = "";
            this.LoadEmployees();
        }
        private void LoadEmployees()
        {
            try

            {
                string query = "select *from EmployeeInfo";

                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    query = query + " where EmployeeName like'%" + txtSearch.Text + "%'";
                }

                DataTable dt = DataAccess.GetDataTable(query);
                dgvEmployeeInfoes.DataSource = dt;
                dgvEmployeeInfoes.Refresh();
                dgvEmployeeInfoes.ClearSelection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Init();
                
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.NewEmployee();
        }
        private void NewEmployee()
        {
            txtEage.Text = "";
            txtEcon.Text = "";
            txtEID.Text = "";
            txtEN.Text = "";
            dgvEmployeeInfoes.ClearSelection();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.LoadEmployees();
        }

        private void DgvEmployeeInfoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string eid = dgvEmployeeInfoes.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                //MessageBox.Show(eid);//
                this.LoadEmployee(eid);
            }
        }
        private void LoadEmployee(string eid)
        {
            try

            {
                string query = "select *from EmployeeInfo where EmployeeID=" + eid;

                DataTable dt = DataAccess.GetDataTable(query);
                if (dt.Rows.Count != 1)
                {
                    return;
                }
                txtEID.Text = dt.Rows[0]["EmployeeID"].ToString();
                txtEcon.Text = dt.Rows[0]["EmployeeContact"].ToString();
                txtEage.Text = dt.Rows[0]["EmployeeAge"].ToString();
                txtEN.Text = dt.Rows[0]["EmployeeName"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEID.Text == "")
                {
                    MessageBox.Show(text: "Please select a Row First");
                    return;
                }
                string query = "delete from EmployeeInfo where EmployeeID=" + txtEID.Text;
                DataAccess.ExecuteQuery(query);
                this.LoadEmployees();
                this.NewEmployee();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string en = txtEN.Text;
            string eid = txtEID.Text;
            string eage = txtEage.Text;
            string econ = txtEcon.Text;

            string message = "Employee Name:" + en + "\n"
                             + "ID:" + eid + "\n"
                             + "Employee Age:" + eage + "\n"
                             + "Employee Contact:" + econ + "\n";
            MessageBox.Show(message);

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connectionString: "Data Source=localhost;Initial Catalog=FlatManagement;Integrated Security=True");
                con.Open();

                String query = "insert into EmployeeInfo(EmployeeName , EmployeeContact , EmployeeAge )" +
                                "values('" + en + "', '" + econ + "', '" + eage + "')";
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


            if (txtEID.Text == "")
            {
                MessageBox.Show(text: "Insert");
            }
            else
            {
                MessageBox.Show(text: "Update");
            }
        }
    }
}
