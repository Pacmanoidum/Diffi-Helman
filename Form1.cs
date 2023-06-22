using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Алгоритм_Диффи_Хелмана
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((ulong.TryParse(a.Text, out ulong r1) & (ulong.TryParse(b.Text, out ulong r2)) & (ulong.TryParse(g.Text, out ulong r3)) & (ulong.TryParse(p.Text, out ulong r4))) == false))
                MessageBox.Show("Заполните поля числами!");
            else
            {
                ulong a1 = ulong.Parse(a.Text);
                ulong g1 = ulong.Parse(g.Text);
                ulong p1 = ulong.Parse(p.Text);
                ulong b1 = ulong.Parse(b.Text);
                AL.Text += Math.Pow(g1, a1) % p1;
                BL.Text += Math.Pow(g1, b1) % p1;
                k1.Text += Math.Pow(double.Parse(BL.Text), a1) % p1;
                k2.Text += Math.Pow(double.Parse(AL.Text), b1) % p1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Text = "";
            g.Text = "";
            p.Text = "";
            b.Text = "";
            AL.Text = "";
            BL.Text = "";
            k1.Text = "";
            k2.Text = "";
        }
    }
}
