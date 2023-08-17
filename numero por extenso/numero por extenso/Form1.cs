using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numero_por_extenso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); if (mensagem == DialogResult.Yes) { this.Close(); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            switch (cboNumeros.Text)
            {
                case "0":
                    txtNumeroExtenso.Text = "Zero";
                    break;
                case "1":
                    txtNumeroExtenso.Text = "Um";
                    break;
                case "2":
                    txtNumeroExtenso.Text = "Dois";
                    break;
                case "3":
                    txtNumeroExtenso.Text = "Tres";
                    break;
                case "4":
                    txtNumeroExtenso.Text = "Quatro";
                    break;
                case "5":
                    txtNumeroExtenso.Text = "Cinco";
                    break;
                case "6":
                    txtNumeroExtenso.Text = "Seis";
                    break;
                case "7":
                    txtNumeroExtenso.Text = "Sete";
                    break;
                case "8":
                    txtNumeroExtenso.Text = "Oito";
                    break;
                case "9":
                    txtNumeroExtenso.Text = "Nove";
                    break;
                case "10":
                    txtNumeroExtenso.Text = "Dez";
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cboNumeros.Text = "";
            txtNumeroExtenso.Text = "";
        }
    }
}
