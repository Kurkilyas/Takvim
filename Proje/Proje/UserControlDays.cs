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
using System.Reflection.Emit;
using System.Diagnostics.Eventing.Reader;

namespace Proje
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }
        //gün için statik değerler oluşturalım
        public static string static_day;
        DateTime bugununTarihi = DateTime.Today;
     
        private void UserControlDays_Load(object sender, EventArgs e)
        {
            
            olayGoruntuleme();
            
            if(lbldays.Text==bugununTarihi.Day.ToString() && Takvim.static_month==bugununTarihi.Month) //Gün tarihini belirleme
            {
                Color arkaPlanRengi = Color.Green;
                this.BackColor = arkaPlanRengi;
            }
                
         
                timer2.Start();
            }
        public void days(int numday) //günleri belirleme
        {
            lbldays.Text = numday.ToString();
           
        }

        private void UserControlDays_Click(object sender, EventArgs e) //kullanıcı denetimine tıkladığında olay ekleme ve çıkarma işlemi
        {
            static_day=lbldays.Text;
            timer1.Start();
           
            EventFormcs eventFormcs = new EventFormcs();
            eventFormcs.Show();
        }
        SqlBaglantisi bgl=new SqlBaglantisi();  //sql bağlantısı açma
        private void olayGoruntuleme()
        {
           

           
            SqlConnection connection = bgl.baglanti();
            connection.Open();
            SqlCommand komut=new SqlCommand("Select olayin_tipi From Olay_Tablosu Where islem_zamani=@k1 ",connection);
            komut.Parameters.AddWithValue("@k1", Takvim.static_year + "/" + Takvim.static_month + "/"+lbldays.Text);
            SqlDataReader dataReader = komut.ExecuteReader();   
            while(dataReader.Read())
            {
                lblOlay.Text = dataReader[0].ToString();
            }
           
            connection.Close();
         




            
            
            
            



        }

        private void lbldays_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
         {
            olayGoruntuleme();
            }
      
        //Bildirim gösterme kısmı
        private void timer2_Tick(object sender, EventArgs e)
        {
             if (!string.IsNullOrEmpty(lblOlay.Text) && this.BackColor == Color.Green)
            {
               
                string zaman=null;
                SqlConnection connection = bgl.baglanti();
                connection.Open();
                SqlCommand komut = new SqlCommand("Select baslangic from Olay_Tablosu where  islem_zamani=@k1 ", connection);
                komut.Parameters.AddWithValue("@k1", Takvim.static_year + "/" + Takvim.static_month + "/" + lbldays.Text);
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    zaman = dataReader[0].ToString();
                }

                connection.Close();
                MessageBox.Show("Bugün saat'da "+   zaman+lblOlay.Text + " Var");
            }

            timer2.Stop();
            timer2.Enabled = false;
           


        }


       


    }
}
