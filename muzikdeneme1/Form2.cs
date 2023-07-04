using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muzikdeneme1
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        private string sorgu;

        public Form2()
        {
            InitializeComponent();
        }

        void KisiGetir()
        {
            string sorgu = "SELECT * FROM ŞARKı";
            conn = new SqlConnection("Data Source=LAPTOP-FSHH81C8\\SQLDOGAN;Initial Catalog=MÜZİK1;Integrated Security=True");
            adapter = new SqlDataAdapter(sorgu, conn);
            ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "ŞARKı");
            dgvGoster.DataSource = ds.Tables["ŞARKı"];
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            KisiGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-FSHH81C8\\SQLDOGAN;Initial Catalog=MÜZİK1;Integrated Security=True"))
            {
                conn.Open();
                string sorgu = "INSERT INTO ŞARKı (SarkiAdi, TurID, AlbumID, SanatciID, Sure) VALUES (@sarkiAdi, @turID, @albumID, @sanatciID, @sure)";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@sarkiAdi", txtSarkiAdi.Text);
                cmd.Parameters.AddWithValue("@turID", Convert.ToInt32(txtTurID.Text));
                cmd.Parameters.AddWithValue("@albumID", Convert.ToInt32(txtAlbumID.Text));
                cmd.Parameters.AddWithValue("@sanatciID", Convert.ToInt32(txtSanatciID.Text));
                cmd.Parameters.AddWithValue("@sure", TimeSpan.Parse(txtSure.Text));
                cmd.ExecuteNonQuery();
            }

            KisiGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-FSHH81C8\\SQLDOGAN;Initial Catalog=MÜZİK1;Integrated Security=True"))
            {
                conn.Open();
                string sorgu = "UPDATE ŞARKı SET SarkiAdi = @sarkiAdi, TurID = @turID, AlbumID = @albumID, SanatciID = @sanatciID, Sure = @sure WHERE SarkiID = @sarkiID";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@sarkiAdi", txtSarkiAdi.Text);
                cmd.Parameters.AddWithValue("@turID", Convert.ToInt32(txtTurID.Text));
                cmd.Parameters.AddWithValue("@albumID", Convert.ToInt32(txtAlbumID.Text));
                cmd.Parameters.AddWithValue("@sanatciID", Convert.ToInt32(txtSanatciID.Text));
                cmd.Parameters.AddWithValue("@sure", TimeSpan.Parse(txtSure.Text));
                cmd.Parameters.AddWithValue("@sarkiID", dgvGoster.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
            }

            KisiGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-FSHH81C8\\SQLDOGAN;Initial Catalog=MÜZİK1;Integrated Security=True"))
            {
                conn.Open();
                string sorgu = "DELETE FROM ŞARKı WHERE SarkiID=@sarkiID";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@sarkiID", dgvGoster.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
            }

            KisiGetir();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables["ŞARKı"].DefaultView;
            dv.RowFilter = "SarkiAdi LIKE '" + txtArama.Text + "%'";
            dgvGoster.DataSource = dv;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
