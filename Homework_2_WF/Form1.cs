using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Byte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From 0 to 255");
        }

        private void Sbyte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From -128 to 127");
        }

        private void Short_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From -32768 to 32767");
        }

        private void Ushort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From 0 to 65535");
        }

        private void Int_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From -2147483648 to 2147483647");
        }

        private void Uint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From 0 to 4294967295");
        }

        private void Long_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From -9223372036854775808 to 9223372036854775807");
        }

        private void Ulong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From 0 to 18446744073709551615");
        }
    }
}
