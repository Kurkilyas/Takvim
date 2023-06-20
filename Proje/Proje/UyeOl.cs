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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }
            SqlBaglantisi bgl = new SqlBaglantisi(); 
        private void bttnUyeOl_Click(object sender, EventArgs e) //sql bağlantısı kullanarak verileri ekledik.
        {
            SqlConnection connection = bgl.baglanti();
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into Kayit_Table (Kullanici_Ad,Kullanici_Soyad,Kullanici_Nickname,Kullanici_Password,Kullanici_TC,Kullanici_No,Kullanici_Email,Kullanici_Adres,Kullanici_Type) values (@k1,@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9)",connection);
            komut.Parameters.AddWithValue("@k1", txtAd.Text);
            komut.Parameters.AddWithValue("@k2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@k3", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@k4", txtPassword.Text);
            komut.Parameters.AddWithValue("@k5", txtTC.Text);
            komut.Parameters.AddWithValue("@k6", txtTelefon.Text);
            komut.Parameters.AddWithValue("@k7", txtEmail.Text);
            komut.Parameters.AddWithValue("@k8", txtAdres.Text);
            komut.Parameters.AddWithValue("@k9", txtType.Text);

           
   

            komut.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Kaydınız gerçekleşmiştir!!!");
            this.Hide();

        }

        private void UyeOl_Load(object sender, EventArgs e)
        {

        }
    }
}
