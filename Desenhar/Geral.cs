using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AcesCEM.Classes
{
    //rotinas de uso geral
    class Geral
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static List<string> PegaTabelasExcel(OleDbConnection conexao, string caminho)
        {
            conexao.Open();
            List<string> listaPlanilhas = new List<string>();
            DataTable dt = conexao.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["TABLE_NAME"].ToString().Contains("$"))
                {
                    listaPlanilhas.Add(dr["TABLE_NAME"].ToString());
                }
            }

            conexao.Close();

            return listaPlanilhas;
        }

        public static string RetornaValorFormatado(Double valor)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            return valor.ToString("N", culture);
        }

        public static string CopyPartOfStringSettingMaxLenght(string sEntrada, int setMaxLenght)
        {
            int lenght = sEntrada.Length;

            if (lenght > setMaxLenght) lenght = setMaxLenght;

            return sEntrada.Substring(0, lenght);
        }

        public static double ConvertDBNullToDouble(object valor)
        {

            if ((valor is null) || (Convert.IsDBNull(valor)))
            {
                valor = 0;
            }

            return Convert.ToDouble(valor);
        }

        public static PropertyInfo[] GetProperties(object obj)
        {
            return obj.GetType().GetProperties();
        }

        public static DateTime ConvertStrToDatePtBr(string data)
        {
            return DateTime.Parse(data, new CultureInfo("pt-BR"));
        }

        public static double StringToDouble(string value)
        {
            double retorno = 0;

            Double.TryParse(value, out retorno);

            return retorno;
        }

        public static void GravaLogErro(string fileName, string messageError)
        {
            string logMessages;

            CriaArquivo(fileName);

            messageError = string.Format(MsgConst.SLogModelo1, DateTime.Now.ToString(), messageError);

            using (StreamReader sr = new StreamReader(fileName))
            {
                logMessages = sr.ReadToEnd();
                sr.Close();

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write(logMessages);
                    sw.Write(messageError);
                    sw.Close();
                }
            }
        }

        public static void CriaArquivo(string fileName)
        {
            if (!File.Exists(fileName))
                File.Create(fileName);
        }

        public static void OpenFileProcess(string processName, string fileName)
        {
            Process.Start(processName, fileName);
        }

        public static void ApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))

                e.Handled = true;

            if (e.KeyChar == ',')
            {
                e.Handled = false;

            }

            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }

        public static void VerificaImportacao<T>(bool importacaoOK, List<T> listaItensNaoImportados)
        {
            if ((importacaoOK) && (listaItensNaoImportados.Count == 0))
            {
                MessageBox.Show(string.Format(MsgConst.SImportouSucesso, MsgConst.SKits), MsgConst.SSucesso, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var tipo = listaItensNaoImportados.GetType().GetGenericArguments()[0];
            }

            MessageBox.Show(MsgConst.SImportouComFalha, MsgConst.SAtencao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //frmItensErroFormatacao frm = new frmItensErroFormatacao();
            //frm.ShowDialog();
            listaItensNaoImportados.Clear();
        }

        public static string FormataCustoItemToString(string valor)
        {
            string retorno = valor;
            //itens em branco
            if (retorno.Trim() == "")
            {
                retorno = "0";
            }
            return retorno = retorno.Replace('.', ',');
        }

        public static string ConcactStrWithSeparator(string source, string valueToConcat, string separator = ",")
        {
            if (string.IsNullOrEmpty(source))
            {
                source = source + valueToConcat;
            }
            else
            {
                source = source + separator + valueToConcat;
            }

            return source;
        }

        public static string EnumToString<T>()
        {
            string retorno = "";

            var listaEnum = Enum.GetValues(typeof(T)).Cast<T>().Select(v => v.ToString()).ToList();
            foreach (var item in listaEnum)
            {
                retorno = ConcactStrWithSeparator(retorno, item);
            }

            return retorno;
        }

        public void PermitirApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)) e.Handled = true;
        }
    }

}

