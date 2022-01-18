using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelimeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox kutu;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Random a = new Random();
            String buton = "b";
          


                for (int i = 0; i < 5; i++)
                {

                   kutu = new TextBox();
                    kutu.MaxLength = 1;
                    kutu.Left = i * 50 + 15;
                    kutu.Top = 20;
                    kutu.Width = 36;
                    kutu.Height = 40;
                    kutu.Text = "";

                kutu.TextAlign = HorizontalAlignment.Center;
                    kutu.Multiline = true;
                    kutu.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    groupBox1.Controls.Add(kutu);

                }
            for (int i = 0; i < 5; i++)
            {

                kutu = new TextBox();
                kutu.MaxLength = 1;
                kutu.Left = i * 50 + 15;
                kutu.Top = 20;
                kutu.Width = 36;
                kutu.Height = 40;
                kutu.Text = "";

                kutu.TextAlign = HorizontalAlignment.Center;
                kutu.Multiline = true;
                kutu.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                groupBox2.Controls.Add(kutu);

            }
            for (int i = 0; i < 5; i++)
            {

                kutu = new TextBox();
                kutu.MaxLength = 1;
                kutu.Left = i * 50 + 15;
                kutu.Top = 20;
                kutu.Width = 36;
                kutu.Height = 40;
                kutu.Text = "";

                kutu.TextAlign = HorizontalAlignment.Center;
                kutu.Multiline = true;
                kutu.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                groupBox3.Controls.Add(kutu);

            }
            for (int i = 0; i < 5; i++)
            {

                kutu = new TextBox();
                kutu.MaxLength = 1;
                kutu.Left = i * 50 + 15;
                kutu.Top = 20;
                kutu.Width = 36;
                kutu.Height = 40;
                kutu.Text = "";

                kutu.TextAlign = HorizontalAlignment.Center;
                kutu.Multiline = true;
                kutu.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                groupBox4.Controls.Add(kutu);

            }
            for (int i = 0; i < 5; i++)
            {

                kutu = new TextBox();
                kutu.MaxLength = 1;
                kutu.Left = i * 50 + 15;
                kutu.Top = 20;
                kutu.Width = 36;
                kutu.Height = 40;
                kutu.Text = "";

                kutu.TextAlign = HorizontalAlignment.Center;
                kutu.Multiline = true;
                kutu.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                groupBox5.Controls.Add(kutu);

            }
            for (int i = 0; i < 5; i++)
            {

                kutu = new TextBox();
                kutu.MaxLength = 1;
                kutu.Left = i * 50 + 15;
                kutu.Top = 20;
                kutu.Width = 36;
                kutu.Height = 40;
                kutu.Text = "";

                kutu.TextAlign = HorizontalAlignment.Center;
                kutu.Multiline = true;
                kutu.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                groupBox6.Controls.Add(kutu);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string tahmin;
            foreach (Control item in groupBox1.Controls)
            {
                textBox1.AppendText(item.Text);
            }
            tahmin = textBox1.Text;

            foreach (Control item in groupBox1.Controls)
            {

                for (int i = 0; i < tahmin.Length; i++)
                {
                    if (item.Text == label1.Text.Substring(i, 1))
                    {
                        item.BackColor = Color.Red;
                       
                    }
                }
            }
        }
    }
}
