using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            webBrowser1.Navigate("https//www.google.com.tr");

            ToolTip Controls_Tooltip(string baslik, string aciklama, Control cntrl)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Active = true; // Görünsün mü?
                toolTip.ToolTipTitle = baslik; // Çıkacak Mesajın Başlığı
                toolTip.ToolTipIcon = ToolTipIcon.Info; // Çıkacak Mesajda yer alacak ıkon
                toolTip.UseFading = true; // Silinerek kaybolma ve yavaşça görünme
                toolTip.UseAnimation = true; // Animasyonlu açılış
                toolTip.IsBalloon = true; // Baloncuk şekli mi dikdörtgen mi?
                toolTip.ShowAlways = true; // her zaman göster
                toolTip.AutoPopDelay = 3000; // Mesajın açık kalma süresi
                toolTip.ReshowDelay = 3000; // Mause çekildikten kaç ms sonra kaybolsun
                toolTip.InitialDelay = 1000; // Mesajın açılma süresi
                toolTip.BackColor = Color.Red; // arka plan rengi
                toolTip.ForeColor = Color.White; // yazı rengi
                toolTip.SetToolTip(cntrl, aciklama); // Hangi kontrolde görünsün
                return toolTip;
            }
            Controls_Tooltip("bu Combox'tır", "Comboboxiçin tooltip tir", comboBox1);
            
            foreach (Control item in this.Controls)
            {
                Controls_Tooltip("Bu " + item.ToString() + " nesnesidir.", "Bu nesnenin adı ise " + item.Name, item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Bu alan boş geçilemez");
                errorProvider1.BlinkRate = 50;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
