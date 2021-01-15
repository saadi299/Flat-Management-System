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
    public partial class AdvertisementInfo : Form
    {
        public AdvertisementInfo()
        {
            InitializeComponent();
        }

        private void AdvertisementInfo_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void Init()
        {
            txtBID.Text = txtOID.Text = txtSearch.Text = txtIn.Text = txtlk.Text = txtrw.Text =txtst.Text=txtID.Text= "";
            try
            {
                string query = "select *from BuildingInfo";
                DataTable dt = DataAccess.GetDataTable(query);

                cmbbuild.DataSource = dt;
                cmbbuild.DisplayMember = "Status";
                cmbbuild.ValueMember = "BID";
                cmbbuild.SelectedItem = null;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            this.LoadAdvertisements();
        }
        private void LoadAdvertisements()
        {
            try

            {
                string query = "select AdvertiseInfo.*,BuildingInfo.BID as 'BuildingID' from AdvertiseInfo , BuildingInfo"
                                        +" where AdvertiseInfo.BID = BuildingInfo.BID";

                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    query = query + " and Status like'%" + txtSearch.Text + "%'";
                }

                DataTable dt = DataAccess.GetDataTable(query);
                dgvAdvertiseInfoes.DataSource = dt;
                dgvAdvertiseInfoes.Refresh();
                dgvAdvertiseInfoes.ClearSelection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Init();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.NewAdvertisement();
        }
        private void NewAdvertisement()
        {
            txtBID.Text = "";
            txtIn.Text = "";
            txtOID.Text = "";
            txtlk.Text = "";
            txtrw.Text = "";
            txtst.Text = "";
            txtID.Text = "";
            cmbbuild.SelectedValue = null;
            dgvAdvertiseInfoes.ClearSelection();
        }

        private void DgvAdvertiseInfoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string bid = dgvAdvertiseInfoes.Rows[e.RowIndex].Cells["BID"].Value.ToString();
                //MessageBox.Show(bid);//
                this.LoadAdvertisement(bid);
            }

        }
        private void LoadAdvertisement(string bid)
        {
            try

            {
                string query = "select *from AdvertiseInfo where BID=" + bid;

                DataTable dt = DataAccess.GetDataTable(query);
                if (dt.Rows.Count != 1)
                {
                    return;
                }
                txtBID.Text = dt.Rows[0]["BID"].ToString();
                txtIn.Text = dt.Rows[0]["Interest"].ToString();
                txtlk.Text = dt.Rows[0]["Look"].ToString();
                txtOID.Text = dt.Rows[0]["OID"].ToString();
                txtrw.Text = dt.Rows[0]["Review"].ToString();
                txtID.Text = dt.Rows[0]["ID"].ToString();
                txtst.Text = dt.Rows[0]["Status"].ToString();
                cmbbuild.SelectedValue   = dt.Rows[0]["BID"].ToString();
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
                if (txtID.Text == "")
                {
                    MessageBox.Show(text: "Please select a Row First");
                    return;
                }
                string query = "delete from AdvertiseInfo where ID=" + txtID.Text;
                DataAccess.ExecuteQuery(query);
                this.LoadAdvertisements();
                this.NewAdvertisement();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.LoadAdvertisements();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string st = txtst.Text;
            string rw = txtrw.Text;
            string oid = txtOID.Text;
            string lk = txtlk.Text;
            string In = txtIn.Text;
            string bid = txtBID.Text;
            string id = txtID.Text;
            string bi = cmbbuild.Text;
            string message = "Status:" + st + "\n"
                             + "ID:" + id + "\n"
                             + "Review:" + rw + "\n"
                             + "BID:" + bid + "\n"
                             + "Look:" + lk + "\n"
                             + "Interested:" + In + "\n"
                             + "Building Info:" +bi+ "\n"
                             + "OID:" + oid + "\n";
            
            MessageBox.Show(message);

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(connectionString: "Data Source=localhost;Initial Catalog=FlatManagement;Integrated Security=True");
                con.Open();

                DataRowView dv = (DataRowView)cmbbuild.SelectedItem;
                int buid = Int32.Parse(dv.Row["BID"].ToString());

                String query = "insert into AdvertiseInfo( Status , Review ,Look , Interest , BID , OID , BuildingInfo )" +
                                "values('" + st + "', '" + rw + "', '" + lk + "','" + In + "', '" + bid + "', '" + oid + "','"+ bi +"')";
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

            if (cmbbuild.SelectedItem == null)
            {
                MessageBox.Show(text: "Invalid BuildingInfo");
                return;
                }

            if (txtID.Text == "")
            {
                MessageBox.Show(text: "Insert");
            }
            else
            {
                MessageBox.Show(text: "Update");
            }
        }

        private void DgvAdvertiseInfoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
