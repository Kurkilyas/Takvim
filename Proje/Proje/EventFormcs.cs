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
    public partial class EventFormcs : Form
    {
        public EventFormcs()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl=new SqlBaglantisi(); //Sınıf sql bağlantısını bir depişken oluşturalım
        private void EventFormcs_Load(object sender, EventArgs e)
        {
            SqlConnection connection = bgl.baglanti(); //bağlantıyı oluşturup açtık ve içindeki tarihe göre verileri aldık
            connection.Open();
            txtTarih.Text = Takvim.static_year + "/" + Takvim.static_month +"/"+ UserControlDays.static_day;
            SqlCommand komut4=new SqlCommand("Select * From Olay_Tablosu Where islem_zamani=@p1",connection);
            komut4.Parameters.AddWithValue("@p1", txtTarih.Text);
            SqlDataReader dr = komut4.ExecuteReader();
            while(dr.Read())  //Eğer onaylayıp okursa aşağıdaki textbox lara yazıcak böylece bir tarihin olayını yada zamanı değiştirmek istediğimiz zaman uğraşmıcaz
            {
                txtBaslangic.Text = dr[1].ToString();
                txtOlayınTanım.Text = dr[2].ToString();
                txtOlayTip.Text = dr[3].ToString(); 
                txtOlayAciklama.Text = dr[4].ToString();    
            }
            connection.Close();
            }
     

        private void btnnkaydet_Click(object sender, EventArgs e)
        {

            SqlConnection connection = bgl.baglanti(); //bağlantıyı açtık ve içine txtboxklardan gelen saat,açıklama vb. şeyleri ekleyerek bağlantıyı kapattık
            connection.Open();
            SqlCommand komut=new SqlCommand("insert into Olay_Tablosu (islem_zamani,baslangic,olayin_tanimlama,olayin_tipi,aciklama) values (@k1,@k2,@k3,@k4,@k5)",connection);
            komut.Parameters.AddWithValue("@k1", txtTarih.Text);
            komut.Parameters.AddWithValue("@k2", txtBaslangic.Text);
            komut.Parameters.AddWithValue("@k3", txtOlayınTanım.Text);
            komut.Parameters.AddWithValue("@k4", txtOlayTip.Text);
            komut.Parameters.AddWithValue("@k5", txtOlayAciklama.Text);
            
            komut.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Olay kaydedilmiştir!!!");

        }

        private void bttnSil_Click(object sender, EventArgs e) //bu button ise tarihe göre istediğiniz veriyi silmeye yarıyor.
        {
            SqlConnection connection = bgl.baglanti();
            connection.Open();
            SqlCommand komut2 = new SqlCommand("Delete From Olay_Tablosu where islem_zamani=@p1",connection);
            komut2.Parameters.AddWithValue("@p1", txtTarih.Text);
            komut2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kayıt silindi!!!");
        }

        private void bttnGuncelle_Click(object sender, EventArgs e) //bu button ise tarihe göre verileri güncellemeye yarıyor
        {
            SqlConnection connection = bgl.baglanti();
            connection.Open();
            SqlCommand komut3 = new SqlCommand("update Olay_Tablosu set baslangic=@p1, olayin_tanimlama=@p2, olayin_tipi=@p3, aciklama=@p4 where islem_zamani=@p5", connection);
            komut3.Parameters.AddWithValue("@p1", txtBaslangic.Text);
            komut3.Parameters.AddWithValue("@p2", txtOlayınTanım.Text);
            komut3.Parameters.AddWithValue("@p3", txtOlayTip.Text);
            komut3.Parameters.AddWithValue("@p4", txtOlayAciklama.Text);
            komut3.Parameters.AddWithValue("@p5", txtTarih.Text);
            komut3.ExecuteNonQuery();
            connection.Close ();
            MessageBox.Show("Güncelleme tamamlandı!!!");
        
        
        }
    }
}
