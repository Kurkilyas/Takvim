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

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlBaglantisi bgl=new SqlBaglantisi();  
        private void button1_Click(object sender, EventArgs e) //Bu button ile kullanıcı tablosundan verileri alarak giriş sağlanır
        {
            SqlConnection connection = bgl.baglanti();
           
            connection.Open();

            SqlCommand komut = new SqlCommand("Select * From Kayit_Table Where Kullanici_Email=@p1 and Kullanici_Password=@p2", connection);
            komut.Parameters.AddWithValue("@p1", txtEmail.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) //Onayladğı takdirde diğer forma geçer yoksa hata verir.
            {
                Takvim takvim = new Takvim();
                takvim.Show();
                this.Hide();
                takvim.label9.Text=txtEmail.Text;
            }
            else
            {
                MessageBox.Show("Email veya şifre Hatalıdır!!!");
            }

           
            connection.Close();


        }

        private void UyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Eğer kullanıcı üye değilse üye olması için bir linke yönlendirilir.
        {
            UyeOl uye = new UyeOl();
            uye.Show();
           
        }
    }
}
