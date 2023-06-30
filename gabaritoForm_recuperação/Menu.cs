using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gabaritoForm_recuperação
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acertos a = new Acertos();
            string[] respostas = { $"{tx_questao1.Text}", $"{tx_questao2.Text}", $"{tx_questao3.Text}", $"{tx_questao4.Text}", $"{tx_questao5.Text}", $"{tx_questao6.Text}", $"{tx_questao7.Text}", $"{tx_questao8.Text}", $"{tx_questao9.Text}", $"{tx_questao10.Text}" };

            int resultado = a.QtdAcertos(respostas);
            lb_acertos.Text = resultado.ToString();

        }
    }
}
