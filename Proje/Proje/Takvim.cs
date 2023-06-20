using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class Takvim : Form
    {
        int month, year;
        //ay ve yıl için başka bir forma aktarabileceğimiz statik değişkenler oluşturduk
        public static int static_month,static_year;
        public Takvim()
        {
            InitializeComponent();
            DisplaDays();

        }
        SqlBaglantisi bgl=new SqlBaglantisi();
        
        private void button1_Click(object sender, EventArgs e) //Sonraki buttonu

        {
            //container'i temizleme
            daycontainer.Controls.Clear();
            
            if(month==12)
            {
                year++;
                month=1;

            }
            else
            {
                month++;
            }
            

            String ayismi = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbltarih.Text = ayismi + "" + year;
            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //gay ve günleri alalım
            int days = DateTime.DaysInMonth(year,month);
            //integer türüne çevirelim
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //önce boş bir usercontrol oluşturalım
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            //şimdi günler için kullanıcı kontrolü oluşturalım
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void lbltarih_Click(object sender, EventArgs e)
        {

        }

        private void Takvim_Load(object sender, EventArgs e)
        {
           


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bttnPrevious_Click(object sender, EventArgs e)
        {
           
            //container'i temizleme işlemi
            daycontainer.Controls.Clear();
            if (month == 1)
            {
                year--;
                month = 12;
            }
            else
            {
                month--;
            }
            //sonraki aya gitmek için ayı azaltmak

            String ayismi = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbltarih.Text = ayismi + "" + year;
            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //yılı ve günü almak
            int days = DateTime.DaysInMonth(year, month);
            //integer türüne çevirelim
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //önce boş bir usercontrol oluşturalım
            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            //şimdi günler için kullanıcı kontrolü oluşturalım
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void DisplaDays()
        {
            DateTime now = DateTime.Now;
            month= now.Month;
            year = now.Year;

            String ayismi=DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbltarih.Text = ayismi+""+year;
            static_month = month;
            static_year = year;
            //Haftanın ilk gümnünü belirleyelim
            DateTime startofthemonth = new DateTime(year, month,1);
            //Ay ve yıl
            int days =DateTime.DaysInMonth(year, month);
            //integer türüne çevirme
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;

            //önce boş bir usercontrol oluşturalım
            for (int i = 1; i < dayofweek; i++) 
            {
                UserControlBlank ucblank= new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            //şimdi günler için kullanıcı kontrolü oluşturalım
            for (int i = 1;i<=days;i++)
            {
                UserControlDays ucdays=new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

       
    }
}
