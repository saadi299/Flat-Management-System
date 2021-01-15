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
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Owner_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            txtOage.Text = txtOcon.Text = txtOID.Text = txtON.Text = txtSearch.Text = "";
            this.LoadOwners();
        }
        private void LoadOwners()
        {
            try

            {
                string query = "select *from OwnerInfo";

                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    query = query + " where OwnerName like'%" + txtSearch.Text + "%'";
                }

                DataTable dt = DataAccess.GetDataTable(query);
                dgvOwnerInfoes.DataSource = dt;
                dgvOwnerInfoes.Refresh();
                dgvOwnerInfoes.ClearSelection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.NewOwner();
        }
        private void NewOwner()
        {
            txtOage.Text = "";
            txtOcon.Text = "";
            txtON.Text = "";
            txtOID.Text = "";
            dgvOwnerInfoes.ClearSelection();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.LoadOwners();
            dgvOwnerInfoes.ClearSelection();
        }

        private void DgvOwnerInfoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string oid = dgvOwnerInfoes.Rows[e.RowIndex].Cells["OID"].Value.ToString();
                //MessageBox.Show(eid);//
                this.LoadOwner(oid);
            }
        }
        private void LoadOwner(string oid)
        {
            try

            {
                string query = "select *from OwnerInfo where OID=" + oid;

                DataTable dt = DataAccess.GetDataTable(query);
                if (dt.Rows.Count != 1)
                {
                    return;
                }
                txtOID.Text = dt.Rows[0]["OID"].ToString();
                txtOcon.Text = dt.Rows[0]["OwnerContact"].ToString();
                txtOage.Text = dt.Rows[0]["OwnerAge"].ToString();
                txtON.Text = dt.Rows[0]["OwnerName"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOID.Text == "")
                {
                    MessageBox.Show(text: "Please select a Row First");
                    return;
                }
                string query = "delete from OwnerInfo where OID=" + txtOID.Text;
                DataAccess.ExecuteQuery(query);
                this.LoadOwners();
                this.NewOwner();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string on = txtON.Text;
            string oid = txtOID.Text;
            string oage = txtOage.Text;
            string ocon = txtOcon.Text;

            string message = "Owner Name:" + on + "\n"
                             + "OID:" + oid + "\n"
                             + "Owner Age:" + oage + "\n"
                             + "Owner Contact:" + ocon + "\n";
            MessageBox.Show(message);

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connectionString: "Data Source=localhost;Initial Catalog=FlatManagement;Integrated Security=True");
                con.Open();

                String query = "insert into OwnerInfo(OwnerName , OwnerContact , OwnerAge )" +
                                "values('" + on + "', '" + ocon + "', '" + oage + "')";
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
            if (txtOID.Text == "")
            {
                MessageBox.Show(text: "Insert");
            }
            else
            {
                MessageBox.Show(text: "Update");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Building bl = new Building();
            bl.Show();
        }

        private void TxtON_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
