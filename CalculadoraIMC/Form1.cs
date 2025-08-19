using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão preenchidos
            if (txbAltura.Text == "")
            {
                MessageBox.Show("Digite a altura: ",
                   "Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbAltura.Text == "")
            {
                MessageBox.Show("Digite seu peso: ", 
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Declarar os Valores
            double peso = double.Parse(txbAltura.Text);
            double altura = double.Parse(txbAltura.Text); 


            double imc = peso / (altura * altura);

            // Resultado do IMC:

            if (imc < 18.5)
            {
                lblSaudavel.Text = "Abaixo do peso";
             
            }
            else if (imc < 24.9)
            {
                lblSaudavel.Text = "Peso ideal";
                
            }
            else if (imc < 29.9)
            {

                lblSaudavel.Text = "Levemente acima do peso";

            }

            else if (imc < 34.9)

            {

                lblSaudavel.Text = "Obesidade Grau I";

            }

            else if (imc < 39.9)

            {

                lblSaudavel.Text = "Obesidade Grau II";

            }

            else if (imc > 40.0)

            {

                lblSaudavel.Text = "Obesidade Grau III";

            }

            else

            {

                MessageBox.Show("Por favor, insira valores numéricos válidos.",

                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // Mostrar o resultado:

            txbIMC.Text = imc.ToString();

        }
    }
}
