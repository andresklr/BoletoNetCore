using System;
using System.Collections.Generic;
using System.IO;

namespace Boleto2Net
{
    /// <summary>
    /// Classe Auxiliar com m�todos de extens�o para executar comandos a partir de um Boleto ou de uma lista de boletos
    /// </summary>
    public static class BoletoHelper
    {
        /// <summary>
        /// Recupera um arquivo HTML com encoding do banco
        /// </summary>
        /// <param name="boleto"></param>
        /// <returns></returns>
        public static byte[] ImprimirHtml(this Boleto boleto)
        {
            throw new NotImplementedException();
        }

        public static Stream GerarRemessa(this Boletos boletos, int numArquivoRemessa, TipoArquivo tipoArquivo = TipoArquivo.CNAB240 )
        {
            ArquivoRemessa rem = new ArquivoRemessa(boletos.Banco, TipoArquivo.CNAB240, numArquivoRemessa);
            MemoryStream ms = new MemoryStream(2048);
            try
            {
                rem.GerarArquivoRemessa(boletos, ms, false);
                ms.Position = 0;
                return ms as Stream;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="boletos"></param>
        /// <returns></returns>
        public static byte[] ImprimirLoteHtml(this Boletos boletos)
        {
            throw new NotImplementedException();
        }

    }
}
