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
using System.Drawing.Text;

namespace FRKTPTUR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string ConnectionString = @"Data Source=DESKTOP-BP453JG;Initial Catalog=FRKTPTUR;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Personel",con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            bool sonuc = false;
            string KullanıcıAd = textBox1.Text;
            string Sifre = textBox2.Text;
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            while (dr.Read())
            {
                if (dr["KullanıcıAd"].ToString().Trim() == KullanıcıAd && dr["Sifre"].ToString().Trim() == Sifre)
                {
                    sonuc = true;
                    break;
                }
            }
            if (sonuc)
            {
                MessageBox.Show("Giriş Başarılı", "Giriş Ekranı");
                sonuc = false;
            }
            else
                MessageBox.Show("Giriş Başarısız !","Giriş Ekranı");

        }
    }
}
