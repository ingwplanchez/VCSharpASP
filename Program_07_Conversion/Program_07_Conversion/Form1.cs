using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program_07_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cent = float.Parse(this.textCent.Text);
            float fahr = (cent * 9 / 5) + 32;
            this.textFahr.Text = fahr.ToString();
        }
    }
}
