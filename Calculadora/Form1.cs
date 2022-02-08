using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnum1.Text)
                || string.IsNullOrEmpty(txtnum2.Text))
            { 
                MessageBox.Show("Complete los campos faltantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            
            { 
               var num1 = int.Parse(txtnum1.Text);
               var num2 = int.Parse(txtnum2.Text);
               var Resultado = (num1 + num2);

               txtResultado.Text = Convert.ToString(Resultado);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnum1.Text)
               || string.IsNullOrEmpty(txtnum2.Text))
            {
                MessageBox.Show("Complete los campos faltantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            { 
               var num1 = int.Parse(txtnum1.Text);
               var num2 = int.Parse(txtnum2.Text);
               var Resultado = (num1 - num2);

               txtResultado.Text = Convert.ToString(Resultado);
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnum1.Text)
               || string.IsNullOrEmpty(txtnum2.Text))
            {
                MessageBox.Show("Complete los campos faltantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            { 
            var num1 = int.Parse(txtnum1.Text);
            var num2 = int.Parse(txtnum2.Text);
            var Resultado = (num1 * num2);

            txtResultado.Text = Convert.ToString(Resultado);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnum1.Text)
               || string.IsNullOrEmpty(txtnum2.Text))
            {
                MessageBox.Show("Complete los campos faltantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            { 
            var num1 = int.Parse(txtnum1.Text);
            var num2 = int.Parse(txtnum2.Text);
            var Resultado = (num1 / num2);

            txtResultado.Text = Convert.ToString(Resultado);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtnum2.Clear();
            txtResultado.Clear();
        }
    }
}
