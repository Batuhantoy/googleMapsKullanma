using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace googlemapskullanma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Search_data_Click(object sender, EventArgs e)
        {
            string mahalle = textBox1.Text;
            string şehir = textBox2.Text;
            string devlet = textBox3.Text;
            string zip = textBox4.Text;

            try
            {
                StringBuilder sorguadresi = new StringBuilder();
                sorguadresi.Append("https://maps.google.com/maps?q=");

                if(mahalle!=string.Empty)
                {
                    sorguadresi.Append(mahalle+","+"+");
                }
                if (şehir != string.Empty)
                {
                    sorguadresi.Append(şehir + "," + "+");
                }
                if (devlet != string.Empty)
                {
                    sorguadresi.Append(devlet + "," + "+");
                }
                if (zip != string.Empty)
                {
                    sorguadresi.Append(zip + "," + "+");
                }
                webBrowser1.Navigate(sorguadresi.ToString());

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"HATA!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string devlet = "Turkey";
            webBrowser1.Navigate("https://maps.google.com/maps?q="+devlet);
            
        }
    }
}
