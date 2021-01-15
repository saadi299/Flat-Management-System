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
    public partial class Building : Form
    {
        public Building()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Building_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            txtadd.Text = txtBID.Text = txtbl.Text = txtRd.Text = txtSearch.Text = "";
            this.LoadBuildings();
        }
        private void LoadBuildings()
        {
            try

            {
                string query = "select *from BuildingInfo";

                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    query = query + " where Block like'%" + txtSearch.Text + "%'";
                }

                DataTable dt = DataAccess.GetDataTable(query);
                dgvBuilding.DataSource = dt;
                dgvBuilding.Refresh();
                dgvBuilding.ClearSelection();
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
            this.NewBuilding();
        }
        private void NewBuilding()
        {
            txtRd.Text = "";
            txtbl.Text = "";
            txtBID.Text = "";
            txtadd.Text = "";
            dgvBuilding.ClearSelection();
        }

        private void DgvBuilding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string bid = dgvBuilding.Rows[e.RowIndex].Cells["BID"].Value.ToString();
                //MessageBox.Show(bid);//
                this.LoadBuilding(bid);
            }
        }
        private void LoadBuilding(string bid)
        {
            try

            {
                string query = "select *from BuildingInfo where BID=" + bid;

                DataTable dt = DataAccess.GetDataTable(query);
                if (dt.Rows.Count != 1)
                {
                    return;
                }
                txtBID.Text = dt.Rows[0]["BID"].ToString();
                txtadd.Text = dt.Rows[0]["Address"].ToString();
                txtbl.Text = dt.Rows[0]["Block"].ToString();
                txtRd.Text = dt.Rows[0]["Road"].ToString();
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
                if (txtBID.Text == "")
                {
                    MessageBox.Show(text: "Please select a Row First");
                    return;
                }
                string query = "delete from BuildingInfo where BID=" + txtBID.Text;
                DataAccess.ExecuteQuery(query);
                this.LoadBuildings();
                this.NewBuilding();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.LoadBuildings();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string bid = txtBID.Text;
            string add = txtadd.Text;
            string bl = txtbl.Text;
            string rd = txtRd.Text;

            string message = "BID:" + bid + "\n"
                             + "Address:" + add + "\n"
                             + "Block:" + bl + "\n"
                             + "Road:" + rd + "\n";
            MessageBox.Show(message);

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connectionString: "Data Source=localhost;Initial Catalog=FlatManagement;Integrated Security=True");
                con.Open();

                String query = "insert into BuildingInfo ( Address , Block , Road )" +
                                "values('" + add + "', '" + bl + "', '" + rd + "')";
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


            if (txtBID.Text == "")
            {
                MessageBox.Show(text: "Insert");
            }
            else
            {
                MessageBox.Show(text: "Update");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AdvertisementInfo adf = new AdvertisementInfo();
            adf.Show();
        }
    }
}
