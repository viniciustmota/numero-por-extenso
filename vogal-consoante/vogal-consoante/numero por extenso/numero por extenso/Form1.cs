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
            switch (cboLetras.Text)
            {
                case "A":
                    txtResultado.Text = "Vogal";
                    break;
                case "B":
                    txtResultado.Text = "Consoante";
                    break;
                case "C":
                    txtResultado.Text = "Consoante";
                    break;
                case "D":
                    txtResultado.Text = "Consoante";
                    break;
                case "E":
                    txtResultado.Text = "Vogal";
                    break;
                case "F":
                    txtResultado.Text = "Consoante";
                    break;
                case "G":
                    txtResultado.Text = "Consoante";
                    break;
                case "H":
                    txtResultado.Text = "Consoante";
                    break;
                case "I":
                    txtResultado.Text = "Vogal";
                    break;
                case "J":
                    txtResultado.Text = "Consoante";
                    break;
                case "K":
                    txtResultado.Text = "Consoante";
                    break;
                case "L":
                    txtResultado.Text = "Consoante";
                    break;
                case "M":
                    txtResultado.Text = "Consoante";
                    break;
                case "N":
                    txtResultado.Text = "Consoante";
                    break;
                case "O":
                    txtResultado.Text = "Vogal";
                    break;
                case "P":
                    txtResultado.Text = "Consoante";
                    break;
                case "Q":
                    txtResultado.Text = "Consoante";
                    break;
                case "R":
                    txtResultado.Text = "Consoante";
                    break;
                case "S":
                    txtResultado.Text = "Consoante";
                    break;
                case "T":
                    txtResultado.Text = "Consoante";
                    break;
                case "U":
                    txtResultado.Text = "Vogal";
                    break;
                case "V":
                    txtResultado.Text = "Consoante";
                    break;
                case "W":
                    txtResultado.Text = "Consoante";
                    break;
                case "X":
                    txtResultado.Text = "Consoante";
                    break;
                case "Y":
                    txtResultado.Text = "Consoante";
                    break;
                case "Z":
                    txtResultado.Text = "Consoante";
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cboLetras.Text = "";
            txtResultado.Text = "";
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
