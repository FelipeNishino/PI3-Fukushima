using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI3___Fukushima
{
    static class Estrategia
    {
        public static void MenorChao()
        {
            //
        }
        public static void MaiorModelo()
        {
            //tem
        }
        public static void MenorModelo()
        {
            //tem
        }
        public static Compra PreencheComFabrica(linha[] linhasPreenchidas)
        {
            Compra compra = new Compra();

            //foreach (linha linha in linhasPreenchidas)
            //{
            //    if (linha.azulejo.quantidade < linha.posicao + 1 && !tabuleiro.verificarAzulejoParede(linha.azulejo.id, linha.posicao, tabuleiro))
            //    {
            //        if (fabricas != null)
            //        {
            //            foreach (Fabrica fabrica in fabricas)
            //            {
            //                azulejo = fabrica.azulejos.Find(azulejoFind => azulejoFind.id == linha.azulejo.id);
            //                if (azulejo != null)
            //                {
            //                    local = "F";
            //                    idFabricaComprada = fabrica.id;
            //                    linhaComprada.azulejo = azulejo;
            //                    linhaComprada.posicao = linha.posicao;
            //                    comprou = true;
            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            azulejo = centro.azulejos.Find(azulejoFind => azulejoFind.id == linha.azulejo.id);
            //            if (azulejo != null)
            //            {
            //                local = "C";
            //                linhaComprada.azulejo = azulejo;
            //                linhaComprada.posicao = linha.posicao;
            //                comprou = true;
            //            }
            //        }
            //    }
            //}

            return compra;
        }
        public static void PreencheComCentro()
        {
            //tem
        }
        public static void MenorCentro()
        {

        }
        public static void MaiorCentro()
        {
            //tem
        }
    }
}
