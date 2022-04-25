using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Conversor_VML_OBJ
{
    public partial class frmConversaoVMLOBJ : Form
    {
        // cria uma instância global de StringWriter
        TextWriter _objFinal = new StringWriter();

        public frmConversaoVMLOBJ()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Método que efetua a conversão dos dados do arquivo VML para a estrutura do arquivo OBJ
        /// </summary>
        /// <param name="nomeArquivoAberto"></param>
        /// <returns>Dados estruturados no formato OBJ</returns>
        public TextWriter Converter_VML_OBJ(string nomeArquivoAberto)
        {
            // cria uma instância de XmlDocument
            XmlDocument doc = new XmlDocument();
            // cria uma instância de StringWriter para armazenar as informações de VML convertido para OBJ
            TextWriter resultadoObj = new StringWriter();
            
            // o método Load() abre o arquivo XML escolhido e armazena as informações em doc
            doc.Load(nomeArquivoAberto);

            // se o checkbox cabeçalho para o arquivo OBJ estiver selecionado, as informações do cabeçalho são incluídas na saída
            if (chkCabecalhoObj.Checked == true)
            {
                // se o checkebox "Tudo na mesma a linha" estiver selecionada, os dados são agregadas sem salto de linha, o facilita a inclusão em HTML5
                if (chkMesmaLinha.Checked == false)
                {
                    // o método WriteLine() escreve as informações no objeto stringWriter inserindo salto de linha
                    resultadoObj.WriteLine("# Blender3D v2.5 OBJ File: <memory2>");
                    resultadoObj.WriteLine("# o Mesh");
                }
                else
                {
                    // o método Write() escreve as informações no objeto stringWriter sem inserir salto de linha
                    resultadoObj.Write("# Blender3D v2.5 OBJ File: <memory2> ");
                    resultadoObj.Write("# o Mesh ");
                }
            }

            XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");

            // cria um vetor de string de 4 posições para separar as informações de cada vértice
            string[] pontoVML = new string[4];

            // cria um vetor de string de 4 posições para separar as informações de cada face
            string[] faceVML = new string[4];

            // cria um contador que é utilizado na correção da numeração sequencial dos vértices do arquivo VML
            int contador = 0;

            // cria uma instância de Dictionary<> cujo par Chave/Valor (Key/Value) que representam o numeração sequencia original VML com o equivalente OBJ
            Dictionary<int, int> equivalente = new Dictionary<int, int>();

            // o método SelectNodes() efetua a leitura de todos os vértices e armazena em pontos
            XmlNodeList pontos = doc.SelectNodes("/vml/node-geometry/layers/layer-vertex-xyz/v", ns);

            // percorre cada um dos vértices armazenados em pontos
            foreach (XmlNode node in pontos)
            {
                // lê um vértice e efetua a separação das coordenadas utilizando como referência o espaço que os separa
                pontoVML = node.InnerText.Split(' ');
                
                if (chkMesmaLinha.Checked == false)
                {
                    // obtem os índices 1, 2 e 3 do vetor pontoVML que contém as coordenadas X,Y e Z e as armazenam separadas em resultadoObj;
                    // o método WriteLine() escreve no formato de vértice do OBJ com salto de linha
                    resultadoObj.WriteLine("v " + pontoVML[1] + " " + pontoVML[2] + " " + pontoVML[3]);
                }
                else
                {
                    // o método Write() escreve no formato de vértice do OBJ sem salto de linha
                    resultadoObj.Write("v " + pontoVML[1] + " " + pontoVML[2] + " " + pontoVML[3] + " ");
                }

                // incrementa em 1 o contador
                contador++;

                // armazena em equivalente a numeração original do vértice do VML, pontoVML[0], e relaciona com a numeração sequencial para o formato OBJ
                equivalente.Add(Convert.ToInt16(pontoVML[0]), contador);
            }

            // o método SelectNodes() efetua a leitura de todas as face e armazena em faces
            XmlNodeList faces = doc.SelectNodes("/vml/node-geometry/layers/layer-polygon-corner-uint32[@name='polygon']/p", ns);
            
            // percorre cada uma das faces
            foreach (XmlNode node in faces)
            {
                // lê uma face e efetua a separação das numerações dos vértices utilizando como referência o espaço que os separa
                faceVML = node.InnerText.Split(' ');

                if (chkMesmaLinha.Checked == false)
                {
                    // obtém a numeração sequencial equivalente dos índices 1, 2 e 3 do vetor faceVML 
                    // que contém os vértices de uma face e as armazenam separadas em resultadoObj;
                    // caso apareça a numeração 4294967295, a substitui por um caracter vazio;
                    // o método WriteLine() escreve no formato de vértice do OBJ com salto de linha
                    resultadoObj.WriteLine("f " +
                        equivalente[Convert.ToInt16(faceVML[0])] + " " +
                        equivalente[Convert.ToInt16(faceVML[1])] + " " +
                        equivalente[Convert.ToInt16(faceVML[2])] + " " +
                        (faceVML[3] == "4294967295" ? "" : equivalente[Convert.ToInt16(faceVML[3])] + ""));
                }
                else
                {
                    // o método Write() escreve no formato de vértice do OBJ sem salto de linha
                    resultadoObj.Write("f " +
                        equivalente[Convert.ToInt16(faceVML[0])] + " " +
                        equivalente[Convert.ToInt16(faceVML[1])] + " " +
                        equivalente[Convert.ToInt16(faceVML[2])] + " " +
                        (faceVML[3] == "4294967295" ? "" : equivalente[Convert.ToInt16(faceVML[3])] + " "));
                }
            }

            // fecha resultadoObj
            resultadoObj.Close();
            resultadoObj.Flush();

            // retorna as informações processadas e armazenadas em resultadoObj
            return resultadoObj;
        }

        /// <summary>
        /// Este método é executado quando o botão Abrir Arquivo é pressionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            // efetua a abertura da caixa de dialogo padrão do Windows de escolha de arquivo para abertura, que retorna um resultado e é armazenado em res
            DialogResult res = ofdArquivoAbrir.ShowDialog();

            // se na caixa de dialogo for pressionado um OK, significa que um arquivo foi selecionado
            if (res == DialogResult.OK)
            {
                // se afirmatio executa o método Converter_VML_OBJ() passando o nome do arquivo selecionado como parâmetro e o resultado é armazenado em _objFinal
                _objFinal = Converter_VML_OBJ(ofdArquivoAbrir.FileName);

                // habilita do botão Salvar Arquivo para ser clicado
                btnSalvarArquivo.Enabled = true;

                // faz a chamada ao método SalvarArquivo() de forma automática mesmo que o botão não tenha sido pressionado
                SalvarArquivo();
            }
        }

        /// <summary>
        /// Este método é executado quando o botão Salvar Arquivo é pressionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvarArquivo_Click(object sender, EventArgs e)
        {
            // faz a chamada ao método SalvarArquivo()
            SalvarArquivo();
        }

        /// <summary>
        /// Este método efetua o salvamento dos dados no formato do arquivo OBJ
        /// </summary>
        private void SalvarArquivo()
        {
            // efetua a abertura da caixa de dialogo padrão do Windows de escolha de arquivo para salvamento, que retorna um resultado e é armazenado em res
            DialogResult res = sfdArquivoSalvar.ShowDialog();

            // se na caixa de dialogo for pressionado um OK, significa que foi passado um nome de arquivo e neste foi salvo as informações
            if (res == DialogResult.OK)
            {
                // o método WriteAllText() da classe File efetua o salvamento das informações contidas em _objFinal e as grava no nome de arquivo desejado
                File.WriteAllText(sfdArquivoSalvar.FileName, _objFinal.ToString());
            }
        }

    }
}
