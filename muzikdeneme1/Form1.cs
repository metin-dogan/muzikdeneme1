using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muzikdeneme1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtadi.Text;
            string sifre = txtsifre.Text;

            string connectionString = "Data Source=LAPTOP-FSHH81C8\\SQLDOGAN;Initial Catalog=MÜZİK1;Integrated Security=True";
            string query = "SELECT * FROM KULLANICI WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";

            using (con = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", sifre);

                con.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("BAŞARILI GİRİŞ YAPTINIZ");
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                
                }
                else
                {
                    MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI. LÜTFEN TEKRAR DENEYİNİZ!!");
                }

                reader.Close();
            }

    }
}
}
