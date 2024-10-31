using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_büfe_satış
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        int kasatutar;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, bilet, su, çay, toplam;
            mısır = Convert.ToInt16(textBox1.Text);
            su = Convert.ToInt16(textBox2.Text);
            çay = Convert.ToInt16(textBox3.Text);
            bilet  = Convert.ToInt16(textBox4.Text);
            toplam = mısır * 4 + su * 2 + çay * 5 + bilet * 10;
            label12.Text = toplam.ToString();

            kasatutar = kasatutar + toplam;
            label10.Text = kasatutar.ToString() + "tl"; 



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
