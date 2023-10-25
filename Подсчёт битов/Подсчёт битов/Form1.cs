using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Подсчёт_битов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int value = (int)numeric.Value;
            //value *= 0x10101;
            //value &= 0x249249;
            //value *= 0x249249;
            //value >>= 21;
            //value &= 7;
            //Answer.Text = value.ToString();

            //int n = (int)numeric.Value;
            //n = ((n >> 1) & 0x55) + (n & 0x55);
            //n = ((n >> 2) & 0x33) + (n & 0x33);
            //n = ((n >> 4) & 0x0F) + (n & 0x0F);
            //Answer.Text = n.ToString();
            ulong n = 0x4100080000100855;
            n -= (n>>1) & 0x5555555555555555ul;
            n = ((n>>2) & 0x3333333333333333ul ) + (n & 0x3333333333333333ul);
            n = ((((n>>4) + n) & 0x0F0F0F0F0F0F0F0Ful)* 0x0101010101010101) >> 56;
            Answer.Text = n.ToString();
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            Answer.Text = "...";
        }
    }
}
