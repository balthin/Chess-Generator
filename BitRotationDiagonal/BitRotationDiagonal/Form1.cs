using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BitRotationDiagonal
{
    public partial class Form1 : Form
    {
        private int[] Rotation45R = 
        {
            00, 02, 05, 09, 14, 20, 27, 35,
            01, 04, 08, 13, 19, 26, 34, 42,
            03, 07, 12, 18, 25, 33, 41, 48,
            06, 11, 17, 24, 32, 40, 47, 53,
            10, 16, 23, 31, 39, 46, 52, 57,
            15, 22, 30, 38, 45, 51, 56, 60,
            21, 29, 37, 44, 50, 55, 59, 62,
            28, 36, 43, 49, 54, 58, 61, 63
        };
        bool[] but;
        ulong[] bit;
        ulong uDec = 0;
        ulong r45 = 0;

        public Form1()
        {
            InitializeComponent();
            but = new bool[64];
            bit = new ulong[64];
            MakeDec();
            DecToHex();
        }
        private void MakeDec()
        {
            uDec = 0;
            for (int i = 0; i < 64; i++)
                uDec |= bit[i] << i;
        }
        private void DecToHex()
        {
            string Ox01 = ((uDec >> 00) & 15).ToString("X");
            string Ox02 = ((uDec >> 04) & 15).ToString("X");
            string Ox03 = ((uDec >> 08) & 15).ToString("X");
            string Ox04 = ((uDec >> 12) & 15).ToString("X");
            string Ox05 = ((uDec >> 16) & 15).ToString("X");
            string Ox06 = ((uDec >> 20) & 15).ToString("X");
            string Ox07 = ((uDec >> 24) & 15).ToString("X");
            string Ox08 = ((uDec >> 28) & 15).ToString("X");
            string Ox09 = ((uDec >> 32) & 15).ToString("X");
            string Ox0A = ((uDec >> 36) & 15).ToString("X");
            string Ox0B = ((uDec >> 40) & 15).ToString("X");
            string Ox0C = ((uDec >> 44) & 15).ToString("X");
            string Ox0D = ((uDec >> 48) & 15).ToString("X");
            string Ox0E = ((uDec >> 52) & 15).ToString("X");
            string Ox0F = ((uDec >> 56) & 15).ToString("X");
            string Ox10 = ((uDec >> 60) & 15).ToString("X");
            Hex.Text = "0x" + Ox10 + Ox0F + Ox0E + Ox0D + Ox0C + Ox0B + Ox0A + 
                Ox09 + Ox08 + Ox07 + Ox06 + Ox05 + Ox04 + Ox03+ Ox02 + Ox01;
        }
        
        private void h1_Click(object sender, EventArgs e)
        {
            but[0] = !but[0];
            ulong u = Convert.ToUInt64(but[0]);
            h1.Text = u.ToString();
            bit[0] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void g1_Click(object sender, EventArgs e)
        {
            but[1] = !but[1];
            ulong u = Convert.ToUInt64(but[1]);
            g1.Text = u.ToString();
            bit[1] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void f1_Click(object sender, EventArgs e)
        {
            but[2] = !but[2];
            ulong u = Convert.ToUInt64(but[2]);
            f1.Text = u.ToString();
            bit[2] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void e1_Click(object sender, EventArgs e)
        {
            but[3] = !but[3];
            ulong u = Convert.ToUInt64(but[3]);
            e1.Text = u.ToString();
            bit[3] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void d1_Click(object sender, EventArgs e)
        {
            but[4] = !but[4];
            ulong u = Convert.ToUInt64(but[4]);
            d1.Text = u.ToString();
            bit[4] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void c1_Click(object sender, EventArgs e)
        {
            but[5] = !but[5];
            ulong u = Convert.ToUInt64(but[5]);
            c1.Text = u.ToString();
            bit[5] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void b1_Click(object sender, EventArgs e)
        {
            but[6] = !but[6];
            ulong u = Convert.ToUInt64(but[6]);
            b1.Text = u.ToString();
            bit[6] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void a1_Click(object sender, EventArgs e)
        {
            but[7] = !but[7];
            ulong u = Convert.ToUInt64(but[7]);
            a1.Text = u.ToString();
            bit[7] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void h2_Click(object sender, EventArgs e)
        {
            but[8] = !but[8];
            ulong u = Convert.ToUInt64(but[8]);
            h2.Text = u.ToString();
            bit[8] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void g2_Click(object sender, EventArgs e)
        {
            but[9] = !but[9];
            ulong u = Convert.ToUInt64(but[9]);
            g2.Text = u.ToString();
            bit[9] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void f2_Click(object sender, EventArgs e)
        {
            but[10] = !but[10];
            ulong u = Convert.ToUInt64(but[10]);
            f2.Text = u.ToString();
            bit[10] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void e2_Click(object sender, EventArgs e)
        {
            but[11] = !but[11];
            ulong u = Convert.ToUInt64(but[11]);
            e2.Text = u.ToString();
            bit[11] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void d2_Click(object sender, EventArgs e)
        {
            but[12] = !but[12];
            ulong u = Convert.ToUInt64(but[12]);
            d2.Text = u.ToString();
            bit[12] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void c2_Click(object sender, EventArgs e)
        {
            but[13] = !but[13];
            ulong u = Convert.ToUInt64(but[13]);
            c2.Text = u.ToString();
            bit[13] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void b2_Click(object sender, EventArgs e)
        {
            but[14] = !but[14];
            ulong u = Convert.ToUInt64(but[14]);
            b2.Text = u.ToString();
            bit[14] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void a2_Click(object sender, EventArgs e)
        {
            but[15] = !but[15];
            ulong u = Convert.ToUInt64(but[15]);
            a2.Text = u.ToString();
            bit[15] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void h3_Click(object sender, EventArgs e)
        {
            but[16] = !but[16];
            ulong u = Convert.ToUInt64(but[16]);
            h3.Text = u.ToString();
            bit[16] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void g3_Click(object sender, EventArgs e)
        {
            but[17] = !but[17];
            ulong u = Convert.ToUInt64(but[17]);
            g3.Text = u.ToString();
            bit[17] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void f3_Click(object sender, EventArgs e)
        {
            but[18] = !but[18];
            ulong u = Convert.ToUInt64(but[18]);
            f3.Text = u.ToString();
            bit[18] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void e3_Click(object sender, EventArgs e)
        {
            but[19] = !but[19];
            ulong u = Convert.ToUInt64(but[19]);
            e3.Text = u.ToString();
            bit[19] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void d3_Click(object sender, EventArgs e)
        {
            but[20] = !but[20];
            ulong u = Convert.ToUInt64(but[20]);
            d3.Text = u.ToString();
            bit[20] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void c3_Click(object sender, EventArgs e)
        {
            but[21] = !but[21];
            ulong u = Convert.ToUInt64(but[21]);
            c3.Text = u.ToString();
            bit[21] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void b3_Click(object sender, EventArgs e)
        {
            but[22] = !but[22];
            ulong u = Convert.ToUInt64(but[22]);
            b3.Text = u.ToString();
            bit[22] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void a3_Click(object sender, EventArgs e)
        {
            but[23] = !but[23];
            ulong u = Convert.ToUInt64(but[23]);
            a3.Text = u.ToString();
            bit[23] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void h4_Click(object sender, EventArgs e)
        {
            but[24] = !but[24];
            ulong u = Convert.ToUInt64(but[24]);
            h4.Text = u.ToString();
            bit[24] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void g4_Click(object sender, EventArgs e)
        {
            but[25] = !but[25];
            ulong u = Convert.ToUInt64(but[25]);
            g4.Text = u.ToString();
            bit[25] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void f4_Click(object sender, EventArgs e)
        {
            but[26] = !but[26];
            ulong u = Convert.ToUInt64(but[26]);
            f4.Text = u.ToString();
            bit[26] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void e4_Click(object sender, EventArgs e)
        {
            but[27] = !but[27];
            ulong u = Convert.ToUInt64(but[27]);
            e4.Text = u.ToString();
            bit[27] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void d4_Click(object sender, EventArgs e)
        {
            but[28] = !but[28];
            ulong u = Convert.ToUInt64(but[28]);
            d4.Text = u.ToString();
            bit[28] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void c4_Click(object sender, EventArgs e)
        {
            but[29] = !but[29];
            ulong u = Convert.ToUInt64(but[29]);
            c4.Text = u.ToString();
            bit[29] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void b4_Click(object sender, EventArgs e)
        {
            but[30] = !but[30];
            ulong u = Convert.ToUInt64(but[30]);
            b4.Text = u.ToString();
            bit[30] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void a4_Click(object sender, EventArgs e)
        {
            but[31] = !but[31];
            ulong u = Convert.ToUInt64(but[31]);
            a4.Text = u.ToString();
            bit[31] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void h5_Click(object sender, EventArgs e)
        {
            but[32] = !but[32];
            ulong u = Convert.ToUInt64(but[32]);
            h5.Text = u.ToString();
            bit[32] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void g5_Click(object sender, EventArgs e)
        {
            but[33] = !but[33];
            ulong u = Convert.ToUInt64(but[33]);
            g5.Text = u.ToString();
            bit[33] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void f5_Click(object sender, EventArgs e)
        {
            but[34] = !but[34];
            ulong u = Convert.ToUInt64(but[34]);
            f5.Text = u.ToString();
            bit[34] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void e5_Click(object sender, EventArgs e)
        {
            but[35] = !but[35];
            ulong u = Convert.ToUInt64(but[35]);
            e5.Text = u.ToString();
            bit[35] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void d5_Click(object sender, EventArgs e)
        {
            but[36] = !but[36];
            ulong u = Convert.ToUInt64(but[36]);
            d5.Text = u.ToString();
            bit[36] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void c5_Click(object sender, EventArgs e)
        {
            but[37] = !but[37];
            ulong u = Convert.ToUInt64(but[37]);
            c5.Text = u.ToString();
            bit[37] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void b5_Click(object sender, EventArgs e)
        {
            but[38] = !but[38];
            ulong u = Convert.ToUInt64(but[38]);
            b5.Text = u.ToString();
            bit[38] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void a5_Click(object sender, EventArgs e)
        {
            but[39] = !but[39];
            ulong u = Convert.ToUInt64(but[39]);
            a5.Text = u.ToString();
            bit[39] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void h6_Click(object sender, EventArgs e)
        {
            but[40] = !but[40];
            ulong u = Convert.ToUInt64(but[40]);
            h6.Text = u.ToString();
            bit[40] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void g6_Click(object sender, EventArgs e)
        {
            but[41] = !but[41];
            ulong u = Convert.ToUInt64(but[41]);
            g6.Text = u.ToString();
            bit[41] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void f6_Click(object sender, EventArgs e)
        {
            but[42] = !but[42];
            ulong u = Convert.ToUInt64(but[42]);
            f6.Text = u.ToString();
            bit[42] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void e6_Click(object sender, EventArgs e)
        {
            but[43] = !but[43];
            ulong u = Convert.ToUInt64(but[43]);
            e6.Text = u.ToString();
            bit[43] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void d6_Click(object sender, EventArgs e)
        {
            but[44] = !but[44];
            ulong u = Convert.ToUInt64(but[44]);
            d6.Text = u.ToString();
            bit[44] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void c6_Click(object sender, EventArgs e)
        {
            but[45] = !but[45];
            ulong u = Convert.ToUInt64(but[45]);
            c6.Text = u.ToString();
            bit[45] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void b6_Click(object sender, EventArgs e)
        {
            but[46] = !but[46];
            ulong u = Convert.ToUInt64(but[46]);
            b6.Text = u.ToString();
            bit[46] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void a6_Click(object sender, EventArgs e)
        {
            but[47] = !but[47];
            ulong u = Convert.ToUInt64(but[47]);
            a6.Text = u.ToString();
            bit[47] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void h7_Click(object sender, EventArgs e)
        {
            but[48] = !but[48];
            ulong u = Convert.ToUInt64(but[48]);
            h7.Text = u.ToString();
            bit[48] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void g7_Click(object sender, EventArgs e)
        {
            but[49] = !but[49];
            ulong u = Convert.ToUInt64(but[49]);
            g7.Text = u.ToString();
            bit[49] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void f7_Click(object sender, EventArgs e)
        {
            but[50] = !but[50];
            ulong u = Convert.ToUInt64(but[50]);
            f7.Text = u.ToString();
            bit[50] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void e7_Click(object sender, EventArgs e)
        {
            but[51] = !but[51];
            ulong u = Convert.ToUInt64(but[51]);
            e7.Text = u.ToString();
            bit[51] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void d7_Click(object sender, EventArgs e)
        {
            but[52] = !but[52];
            ulong u = Convert.ToUInt64(but[52]);
            d7.Text = u.ToString();
            bit[52] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void c7_Click(object sender, EventArgs e)
        {
            but[53] = !but[53];
            ulong u = Convert.ToUInt64(but[53]);
            c7.Text = u.ToString();
            bit[53] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void b7_Click(object sender, EventArgs e)
        {
            but[54] = !but[54];
            ulong u = Convert.ToUInt64(but[54]);
            b7.Text = u.ToString();
            bit[54] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void a7_Click(object sender, EventArgs e)
        {
            but[55] = !but[55];
            ulong u = Convert.ToUInt64(but[55]);
            a7.Text = u.ToString();
            bit[55] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void h8_Click(object sender, EventArgs e)
        {
            but[56] = !but[56];
            ulong u = Convert.ToUInt64(but[56]);
            h8.Text = u.ToString();
            bit[56] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void g8_Click(object sender, EventArgs e)
        {
            but[57] = !but[57];
            ulong u = Convert.ToUInt64(but[57]);
            g8.Text = u.ToString();
            bit[57] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void f8_Click(object sender, EventArgs e)
        {
            but[58] = !but[58];
            ulong u = Convert.ToUInt64(but[58]);
            f8.Text = u.ToString();
            bit[58] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void e8_Click(object sender, EventArgs e)
        {
            but[59] = !but[59];
            ulong u = Convert.ToUInt64(but[59]);
            e8.Text = u.ToString();
            bit[59] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void d8_Click(object sender, EventArgs e)
        {
            but[60] = !but[60];
            ulong u = Convert.ToUInt64(but[60]);
            d8.Text = u.ToString();
            bit[60] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void c8_Click(object sender, EventArgs e)
        {
            but[61] = !but[61];
            ulong u = Convert.ToUInt64(but[61]);
            c8.Text = u.ToString();
            bit[61] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void b8_Click(object sender, EventArgs e)
        {
            but[62] = !but[62];
            ulong u = Convert.ToUInt64(but[62]);
            b8.Text = u.ToString();
            bit[62] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }
        private void a8_Click(object sender, EventArgs e)
        {
            but[63] = !but[63];
            ulong u = Convert.ToUInt64(but[63]);
            a8.Text = u.ToString();
            bit[63] = u;
            MakeDec();
            Status.Text = uDec.ToString();
            DecToHex();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Hex.Text);
        }
        private void bClear_Click(object sender, EventArgs e)
        {
            but = new bool[64];
            bit = new ulong[64];
            MakeDec();
            DecToHex();
        }
        private void Right45_Click(object sender, EventArgs e)
        {
            r45 = 0;
            ulong b = 1;
            int shift = 0;
            for (int i = 0; i < 64; i++, b >>= i)
            {
                shift = Rotation45R[i];
                if ((uDec & b) != 0)
                    r45 |= 1ul << shift;
            }
        }
    }
}
