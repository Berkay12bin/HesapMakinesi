using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SeçiliButonlar(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && label1.Text=="0")
            {
                textBox1.Text = "";
                label1.Text = "";
            }
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
            label1.Text = label1.Text + ((Button)sender).Text;
        }
        

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",")<1 && label1.Text.IndexOf(",")<1)
            {
                textBox1.Text = textBox1.Text + ",";
                label1.Text = label1.Text + ",";

            }
        }

        


        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "0";
        }

        
        double sayi;
        bool sonuc1;
        
        double sayi1, sayi2, sonuc;
        
        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "+";
            label1.Text = label1.Text + "+";
            textBox1.Text = "0";
            secim = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "-";
            label1.Text = label1.Text + "-";
            textBox1.Text = "0";



            secim = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
                sayi1 = double.Parse(textBox1.Text);
                textBox1.Text = textBox1.Text + "x";
                label1.Text = label1.Text + "x";
                textBox1.Text = "0";

                secim = 3;
            
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "/";
            label1.Text = label1.Text + "/";
            textBox1.Text = "0";

            secim = 4;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "%";
            label1.Text = label1.Text + "%";
            textBox1.Text = "0";

            secim = 5;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            textBox1.Text = "";
            label1.Text = "";
            int i;
            for (i = 0; i < veri.Length - 1; i++)
            {
                textBox1.Text += veri[i].ToString();
                label1.Text+= veri[i].ToString();
            }
        }





        private void button21_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(label1.Text);
            sayi1 = double.Parse(textBox1.Text);
            sayi1 = sayi1 * -1;
            label1.Text = sayi1.ToString();
            textBox1.Text = sayi1.ToString();
        }
        


        private void button17_Click(object sender, EventArgs e)
        {
            
            sayi2 = double.Parse(textBox1.Text);
            if (sonuc1 == true && secim == 6)
            {
                textBox1.Text = sayi1.ToString();
                label1.Text = sayi1.ToString();
                textBox1.Text = "(" + sayi1;
            }
            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
                textBox1.Text = sonuc.ToString();
                label1.Text = sonuc.ToString();
            }
            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
                textBox1.Text = sonuc.ToString();
                label1.Text = sonuc.ToString();
            }
            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
                textBox1.Text = sonuc.ToString();
                label1.Text = sonuc.ToString();
            }
            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
                textBox1.Text = sonuc.ToString();
                label1.Text = sonuc.ToString();
            }
            if (secim == 5)
            {
                sonuc = sayi1 * sayi2/100;
                textBox1.Text = sonuc.ToString();
                label1.Text = sonuc.ToString();
            }

            


        }

       
        int secim = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }   
}
