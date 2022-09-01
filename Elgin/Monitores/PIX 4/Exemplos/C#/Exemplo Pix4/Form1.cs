using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Exemplo_Pix4
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = E1_Pix4.AbreConexaoDisplay("COM5");

            MessageBox.Show(this, "Retorno: " + retorno);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = E1_Pix4.DesconectarDisplay();

            MessageBox.Show(this, "Retorno: " + retorno);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = E1_Pix4.InicializaDisplay();

            MessageBox.Show(this, "Retorno: " + retorno);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            int retorno;
                retorno = E1_Pix4.CarregaImagemDisplay("P1.jpg", "./P1.jpg" , 320, 480);
                MessageBox.Show(this, "Retorno Carregar Imagem: " + retorno);
                retorno = E1_Pix4.ApresentaImagemDisplay("P1.jpg", 0, 0, 1);
                MessageBox.Show(this, "Retorno Apresentar Imagem: " + retorno);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = E1_Pix4.ApresentaQrCode("Teste de QRCode", 150, 90, 140);

            MessageBox.Show(this, "Retorno: " + retorno);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = E1_Pix4.ApresentaTextoColorido("Teste de Texto", 1, 30, 100, 40, "#000000");

            MessageBox.Show(this, "Retorno: " + retorno);
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            E1_Pix4.ApresentaListaCompras("BOLO DE MORANGO", "99.98");
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
           E1_Pix4.InicializaLayoutPagamento("99.00","39.99", "60.00");
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            E1_Pix4.AdicionaFormaPagamento(1, "60.00");
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = E1_Pix4.ObtemVersaoFirmware();
            MessageBox.Show(this, "Retorno: " + retorno);
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            Boolean retorno;
            retorno = E1_Pix4.ObtemConexao();
            MessageBox.Show(this, "Retorno: " + retorno);
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = E1_Pix4.ReinicializaDisplay();
            MessageBox.Show(this, "Retorno: " + retorno);
        }
    }
}