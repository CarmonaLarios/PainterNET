using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcesCEM.Classes
{
    public class MsgConst
    {
        public const string SImpPesoAces = "Importação de PESO dos Componentes";
        public const string SSiteEg = "www.esquadgroup.com.br";
        public const string SSemConexaoBD = "Não consegui conexão com o banco de dados.";
        public const string SDllNaoEncontrada = "Dll não encontrada.";
        public const string SArqExcelNaoSelecionado = "Nenhum arquivo Excel selecionado.";
        public const string SArqExcelInvalido = "Tabela Excel inválida!";
        public const string SAtencao = "Atenção!";
        public const string SErro = "Erro!";
        public const string SAcesDatabaseEngineNotInstalled = "O aplicativo Aces Database não está instalado na máquina. Deseja instalar?";
        public const string SCreateColuna = "Criando colunas...";
        public const string SSucesso = "Sucesso!";
        public const string SKits = "Kits";


        //importação de planilhas
        public const string SImportouSucesso = "Preços Atualizados! Para que o valor dos {0} sejam atualizados na obra , re-calcule a obra!";
        public const string SImportouComFalha = "A importação foi realizada, mas alguns itens não foram atualizados.Clique em OK para detalhes.";


        //erros
        public const string SFalhaImport = "Verifique se os campos código/custo dos iten(s) não estão em branco ou com " +
                                           "pontuação na planilha Excel (Ex: 3.5). A formatação do custo deve ser com vírgula (Ex: 3,5). " +
                                           "Clique no botão de informação para mais detalhes.";

        public const string SFalhaImport1 = "Falha na importação. Verifique o log para mais detalhes.";

        //campos obrigatórios importação
        public const string SCampoObrigatorioAcesObra = "Os seguintes campos são obrigatórios: Código, cor e preço item.";
        public const string SCampoObrigatorioAcesNMof = "Os seguintes campos são obrigatórios: Código, referência, descrição, cor, quantidade, ipi, unidade item e unidade embalagem.";
        public const string SCampoObrigatorioSuperficie = "Os seguintes campos são obrigatórios: Código, preço item.";
        public const string SCampoObrigatorioKits = "Os seguintes campos são obrigatórios: Código, cor, espessura, largura, altura e custo.";
        public const string SCampoObrigatorioPerf = "Os seguintes campos são obrigatórios: Código e custo.";
        public const string SUnidadeEmbalagemItem = "Para unidade item e unidade embalagem, poderão ser usados os seguintes valores: {0}.";

        //log
        public static string SLogModelo1 = "[DataHora:{0}]" + Environment.NewLine +
                                           "Erro:{1}" + Environment.NewLine;
    }
}
