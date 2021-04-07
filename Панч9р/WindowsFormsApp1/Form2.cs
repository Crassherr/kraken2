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
    public partial class Form2 : Form
    {
        Form1 form1;
        int sec = 0;



        
        public Form2(Form1 f1)
        {
            InitializeComponent();

            //f1.BackColor = Color.Aqua;
            form1 = f1;

            Timer t = new Timer();
               t.Interval = 100;
                  t.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2022, 1, 1);
            DateTime dtNow = DateTime.Now;

            TimeSpan dif = (dt - dtNow);
            

            label1.Text = "До праздника"+ ++sec;
        }
    }
}
