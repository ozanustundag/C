using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //delegate int Del(int x);
        //delegate void Yaz(string y);
        public Form1()
        {
            
            InitializeComponent();
            //this.Load += Form1_Load;
            //this.DoubleClick += Form1_DoubleClick;

            //Del dellmydelegate = x => x * x;
            // Yaz yazmydelegate = y => MessageBox.Show(y);
            // int sayi = dellmydelegate(2);
            // MessageBox.Show(sayi.ToString());
            // yazmydelegate("sda");
            //  this.Click += Form1_Click;
            // this.Click += (s, e) => { MessageBox.Show(((MouseEventArgs)e).Location.ToString()); };

            // dinamik nesne ve event kullanımı

            Button btn = new Button();
            btn.Text = "Tıkla?";
            btn.Name = "btntikla";
            btn.Width = 200;
            btn.Height = 50;
            btn.Left = btn.Width + 5;
            btn.Click += delegate (object s, EventArgs e)
             {
                 string mesaj = (s as Button).Text;
                 MessageBox.Show(mesaj);

             };
            this.Controls.Add(btn);
            button1.Click += (s, e) => { MessageBox.Show("tikkk"); }
            ;
        }

        //private void Form1_Click(object sender, EventArgs e)
        //{
           // MessageBox.Show(((MouseEventArgs)e).Location.ToString());
        //}

        //private void Form1_DoubleClick(object sender, EventArgs e)
        //{
        //    MessageBox.Show("dubleklik");

        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show("selam");

        //}
    }
}
