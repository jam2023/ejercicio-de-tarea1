using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_de_Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int PositivoNegativo(int num)
        {
            if (num < 0)
            {
                txtPositivoNega.Text = "Numero Negativo";
            }
            else
            {
                txtPositivoNega.Text = "Numero Positivo";
            }

            return num;
        }

        public int ParImpar(int num)
        {
            if ((num % 2) == 0)
            {
                txtParImpar.Text = "Numero Par";
            }
            else
            {
                txtParImpar.Text = "Numero Impar";
            }

            return num;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ParImpar(int.Parse(numerotextBox.Text));
            PositivoNegativo(int.Parse(numerotextBox.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numerotextBox.Clear();
            txtParImpar.Clear();
            txtPositivoNega.Clear();    
        }
    }
}
