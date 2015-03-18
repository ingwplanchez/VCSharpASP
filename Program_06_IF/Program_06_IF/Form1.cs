using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program_06_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonComparar_Click(object sender, EventArgs e)
        {
            

            try
            { // INicio del Try
                int x, y;

                x = int.Parse(textNum1.Text);
                y = int.Parse(textNum2.Text);

                if (x>y){
                    MessageBox.Show("El numero " + x + " es mayor.");
                    label1.Text = "El numero " + x + " es mayor.";
                    label1.Visible = true;
                }

                else if (x < y)
                {
                    MessageBox.Show("El numero " + y + " es mayor.");
                    label1.Text = "El numero " + y + " es mayor.";
                    label1.Visible = true;
                }

                else
                {
                    label1.Text = "Los numeros son iguales.";
                    label1.Visible = true;
                }
            } // Fin del try

            catch(FormatException) {
                
                    MessageBox.Show("Formato Invalido.");
                
            }
        }
    }
}
