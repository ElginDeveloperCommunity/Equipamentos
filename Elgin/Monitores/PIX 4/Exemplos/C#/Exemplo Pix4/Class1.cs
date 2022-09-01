using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Pix4
{
    internal class E1_Pix4
    {
        [DllImport("E1_PIX401.dll")] public static extern int AbreConexaoDisplay(string porta);
        [DllImport("E1_PIX401.dll")] public static extern int DesconectarDisplay();
        [DllImport("E1_PIX401.dll")] public static extern int InicializaDisplay();
        [DllImport("E1_PIX401.dll")] public static extern int ReinicializaDisplay();
        [DllImport("E1_PIX401.dll")] public static extern int CarregaImagemDisplay(string fileName, string filePath, int largura, int altura); 
        [DllImport("E1_PIX401.dll")] public static extern int ApresentaImagemDisplay(string fileName, int x, int y, int tipo);
        [DllImport("E1_PIX401.dll")] public static extern int ApresentaQrCode(string qrCode, int tamanho, int posHorizoltal, int posVertical);
        [DllImport("E1_PIX401.dll")] public static extern int ApresentaTextoColorido(string texto, int fonte, int tamanho, int posHorizontal, int posVertical, string corHexa);
        [DllImport("E1_PIX401.dll")] public static extern void ApresentaListaCompras(string descricao, string valor);
        [DllImport("E1_PIX401.dll")] public static extern void InicializaLayoutPagamento(string subTotal, string desconto, string totalPagar);
        [DllImport("E1_PIX401.dll")] public static extern int AdicionaFormaPagamento(int tipoPagamento, string valor);
        [DllImport("E1_PIX401.dll")] public static extern int ObtemVersaoFirmware();
        [DllImport("E1_PIX401.dll")] public static extern Boolean ObtemConexao();



    }
}
