using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program_05_Delegados
{
    public partial class Form1 : Form
    {

        delegate void Delegado(String str);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delegado d = new Delegado(this.mostrarMsg);
            d += this.cambiarEtiqueta;
            d("hola mundo");
        }

        private void mostrarMsg(String msg) {
            System.Windows.Forms.MessageBox.Show(msg);
        }

        private void cambiarEtiqueta(String msg) { 
            this.label1.Text = msg;
        }
    }
}
