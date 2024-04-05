using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static double sayi1, sayi2, sonuc;
        static string islem;

        protected void Sifir_Click(object sender, EventArgs e)
        {
            Ekleme("0");
        }

        protected void Esittir_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(TextBox1.Text);
            TextBox1.Text = "";
            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            if (islem =="/")
            {
                sonuc = sayi1 / sayi2;
            }
            TextBox1.Text = Convert.ToString(sonuc);
            Cikti.Text+=Convert.ToString(sayi2)+"=" + Convert.ToString(sonuc);

        }

        protected void Toplama_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(TextBox1.Text);
            islem = "+";
            Cikti.Text = Convert.ToString(sayi1) + islem;
            TextBox1.Text = "";
        }
        protected void Cikarma_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(TextBox1.Text);
            islem = "-";
            TextBox1.Text = "";
            Cikti.Text = "";
            Cikti.Text = Convert.ToString(sayi1) + islem;
        }
        protected void Uc_Click(object sender, EventArgs e)
        {
            Ekleme("3");
        }

        protected void Iki_Click(object sender, EventArgs e)
        {
            Ekleme("2");
        }

        protected void Bir_Click(object sender, EventArgs e)
        {
            Ekleme("1");
        }

        protected void Ekleme (string sayi)
        {
            TextBox1.Text = TextBox1.Text + "0";
            TextBox1.Text += sayi;
        }
        protected void Carpma_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(TextBox1.Text);
            islem = "*";
            TextBox1.Text = "";
            Cikti.Text = "";
            Cikti.Text = Convert.ToString(sayi1) + islem;
        }

        protected void Yedi_Click(object sender, EventArgs e)
        {
            Ekleme("7");
        }

        protected void Sekiz_Click(object sender, EventArgs e)
        {
            Ekleme("8");
        }

        protected void Dokuz_Click(object sender, EventArgs e)
        {
            Ekleme("9");
        }

        protected void Bolme_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(TextBox1.Text);
            islem = "/";
            TextBox1.Text = "";
            Cikti.Text = "";
            Cikti.Text = Convert.ToString(sayi1) + islem;
        }

        protected void Dort_Click(object sender, EventArgs e)
        {
            Ekleme("4");
        }

        protected void Temizle_Click(object sender, EventArgs e)
        {
            TextBox1.Text = String.Empty;
            Cikti.Text = String.Empty;
        }
    

        protected void Bes_Click(object sender, EventArgs e)
        {
            Ekleme("5");
        }

        protected void Alti_Click(object sender, EventArgs e)
        {
            Ekleme("6");
        }

    }
}

    