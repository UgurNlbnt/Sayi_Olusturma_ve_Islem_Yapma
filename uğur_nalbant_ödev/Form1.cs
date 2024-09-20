using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uğur_nalbant_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            int[] sayilar= new int[20];
            int[] sayilar2 = new int[20];

            lstBox1.Items.Clear();
            lstBox2.Items.Clear();

            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                int sayi1 = rnd.Next(1, 1000);
                int sayi2 = rnd.Next(1, 1000);
                sayilar[i] = sayi1;
                sayilar2[i] = sayi2;
            }
            Array.Sort(sayilar);
            {
                for (int i = 0; i < 20; i++)
                {
                    lstBox1.Items.Add(sayilar[i]);
                }
            Array.Sort(sayilar2);
                {
                    for (int i = 0; i < 20; i++)
                    {
                        lstBox2.Items.Add(sayilar2[i]);
                    }
                }
            }

        }

        private void cmbislem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbislem.Items.Add("TOPLA");
            cmbislem.Items.Add("ÇIKART");
            cmbislem.Items.Add("ÇARPMA");
            cmbislem.Items.Add("BÖLME");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            string sayi1 = lstBox1.SelectedItem.ToString();
            string sayi2 = lstBox2.SelectedItem.ToString();


            if (cmbislem.SelectedIndex == 0)
            {
                int toplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);
                lblsonuc.Text = toplam.ToString();
            }
            else if (cmbislem.SelectedIndex == 1)
            {
                int cıkart = Convert.ToInt32(sayi1) - Convert.ToInt32(sayi2);
                lblsonuc.Text = cıkart.ToString();
            }
            else if (cmbislem.SelectedIndex == 2)
            {
                int carpma = Convert.ToInt32(sayi1) * Convert.ToInt32(sayi2);
                lblsonuc.Text = carpma.ToString();
            }
            else if (cmbislem.SelectedIndex == 3)
            {
                double bölme = Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2);
                lblsonuc.Text = bölme.ToString("F2");
            }
        }
    }
}

