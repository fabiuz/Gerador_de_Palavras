using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;

namespace Gerador_de_Palavras
{
    public partial class Form1 : Form
    {
        private string strDiretorio = "";
        //private string caracteres_selecionados = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~ÀÁÂÃÇÉÊÍÒÓÔÕÚàáâãçéêíóôõú";
        private string caracteres_selecionados = "";
        //caracteres_selecionados = "";
        private List<string> lista_de_palavras;
        private List<string> proxima_lista_de_palavras;

        private long linhas_por_arquivo = 500;
        private int caracteres_por_palavra = 10;

        private bool bInterromper_geracao = false;

        private string[] todos_os_caracteres;
        private string[] palavras_geradas;


        private long contador_de_palavras = 0;
        private long contador_de_arquivos = 0;

        // A quantidade de caracteres em uma única palavra.
        private long quantidade_de_caracteres = 1;

        // A variável 'diretorio_anterior' serve para guardar o diretório selecionado pelo usuário.
        // A variável 'diretorio' serve para guardar o diretório que criamos e qual entraremos nele.
        private string strDiretorio_atual = "";
        private string strDiretorio_anterior = "";
        private string strDiretorio_selecionado = "";

        // Ao clicarmos no botão btnGerar, iremos criar um Thread, para não bloquear a UI.
        private Thread thread_de_palavras;

        // Vamos criar variáveis para guardar posição do ponteiro no arquivo
        // Pois estamos utilizando acesso leitura e gravação.
        long posicao_da_proxima_leitura = 0;
        long posicao_da_proxima_gravacao = 0;
        
        // Os fluxos abaixos, apontarão para o mesmo arquivo, um será de leitura e outro de gravação
        // por isso, utilizaremos as variáveis acima pra manter trilha em que posição devemos ler ou gravar.
        StreamReader arquivo_proximo_ler;
        StreamWriter arquivo_proximo_gravar;

        // Toda vez que a quantidade de linhas for excedida, será gerada um novo arquivo para guardar
        // todos as palavras geradas, então, o fluxo abaixo, guardará o nome do arquivo que foi lido
        // e o nome do arquivo que foi gerado lendo este arquivo e após este indicará se a leitura completa
        // foi realizada ou não.
        StreamWriter arquivo_lido_arquivo_gerado;

        // Não iremos definir esta variável local no método pois, precisaremos do nome do último arquivo
        // gerado em vários métodos da classe.
        private string arquivo_gerado;

        // Indica qual é o arquivo que estamos lendo para formar as novas palavras.
        private string arquivo_sendo_lido;

        // Toda vez que o usuário clicar no botão btnGerar é criado um diretório abaixo do diretório
        // onde o usuário selecionou o diretório onde deve guardar os arquivos, tal diretório
        // terão a data e hora neste formato: YYYY_MM_dd_HH_mm_ss
        private string strData_Hora;      
        
        private void Gerar_Palavras()
        {
            // Aqui, estamos definindo uma variável local para guardar a quantidade de linha informada
            // pelo usuário, isto é utilizando pois o usuário pode alterar a quantidade após
            // estar processando e pode surgir algum bug.
            long qt_maxima_de_linhas_no_arquivo = linhas_por_arquivo;

            // Vamos verificar se a lista de caracteres está vazia, se sim, retornar
            if (string.IsNullOrEmpty(caracteres_selecionados))
            {
                MessageBox.Show("Você deve selecionar pelo menos 1 caractere.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(strDiretorio_selecionado))
                strDiretorio_selecionado = Directory.GetCurrentDirectory();

            strDiretorio_atual = strDiretorio_selecionado;
            strDiretorio_anterior = strDiretorio_atual;

            strData_Hora = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
            strDiretorio_atual = Path.Combine(strDiretorio_atual, strData_Hora);
            if (!Directory.Exists(strDiretorio_atual))
            {
                try
                {
                    // Vamos tentar criar o diretório.
                    Directory.CreateDirectory(strDiretorio_atual);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Preencher lista.
            lista_de_palavras = new List<string>();
            foreach(var chCaractere in caracteres_selecionados.ToArray())
            {
                lista_de_palavras.Add(chCaractere.ToString());
            }
            
            try {

                // O algorítmo que gera todas as palavras possíveis funciona desta forma:
                // Dado um conjunto de caracteres "A", para gerar um conjunto de palavras "B", inicial
                // pega-se, cada caractere do conjunto de caracteres "A" e considera com um conjunto de
                // palavras de 1 caractere cada.
                // Em seguida, para formar um conjunto de palavras "C", pega-se
                // a primeira palavra do conjunto de palavras de B e o primeiro caractere de A;


                // Cada vez que um arquivo é criado, iremos gravar o caminho do arquivo na próxima linha
                // disponível do arquivo que termina por nome de '_proximo_arquivo.txt'.
                // No loop for: 'for(;;)', será lido o próximo arquivo a ser processado, tal informação
                // está no arquivo '_proximo_arquivo.txt'.
                // E toda vez que um arquivo acabar de ser processado ele será gravado no arquivo '_arquivo_ja_lido.txt'.

                string arquivo_proximo = Path.Combine(strDiretorio_atual, strData_Hora + "_proximo_arquivo.txt");

                FileStream file_arquivo_proximo = new FileStream(arquivo_proximo, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

                arquivo_proximo_ler = new StreamReader(file_arquivo_proximo, Encoding.UTF8);
                arquivo_proximo_gravar = new StreamWriter(file_arquivo_proximo, Encoding.UTF8);                

                // Guarda o nome dos arquivos já lidos.
                string arquivo_ja_lido = Path.Combine(strDiretorio_atual, strData_Hora + "_arquivo_ja_lido.txt");
                StreamWriter arquivo_ja_lido_stream = new StreamWriter(arquivo_ja_lido);

                // Guarda o nome do arquivo lido e o nome do arquivo que foi gerado lendo este arquivo.
                string strArquivo = Path.Combine(strDiretorio_atual, strData_Hora + "_arquivo_lido_arquivo_gerado.txt");
                arquivo_lido_arquivo_gerado = new StreamWriter(strArquivo);

                // Gerar o nome do primeiro arquivo.
                quantidade_de_caracteres = 1;

                // Dentro da função 'Gerar_Nome_de_Arquivo', o contador de arquivo é incrementado em 1.
                // O primeiro arquivo, terá em uma parte do nome "arq_0000000000", como nome inicial.
                contador_de_arquivos = -1;
                Gerar_Nome_de_Arquivo();

                // Vamos gravar o nome do primeiro arquivo que será criado, na próxima linha disponível em '*_proximo_arquivo.txt".
                arquivo_proximo_gravar.BaseStream.Position = 0;
                arquivo_proximo_gravar.WriteLine(arquivo_gerado);
                arquivo_proximo_gravar.Flush();
                posicao_da_proxima_gravacao = arquivo_proximo_gravar.BaseStream.Position;

                // Vamos criar o arquivo para criar a lista de palavras.
                StreamWriter arquivo_gerado_inicial;
                try
                {
                    arquivo_gerado_inicial = new StreamWriter(arquivo_gerado);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gravar contéudo da lista para o arquivo
                foreach(var strPalavras in lista_de_palavras)
                {
                    arquivo_gerado_inicial.WriteLine(strPalavras);
                }
                arquivo_gerado_inicial.Close();

                int contagem_de_linha = 0;
                contador_de_arquivos = 1;
                quantidade_de_caracteres = 2;
                
                var strTexto = "";

                // Cria um objeto para guardar informações para ser enviado quando
                // executar utilizando o controle background.
                palavras_info informacao_das_palavras = new palavras_info();

                // Vamos definir a variável abaixo para falso,
                // se o usuário decidir parar a geração definir como true.
                bInterromper_geracao = false;
                arquivo_proximo_ler.BaseStream.Position = 0;

                proxima_lista_de_palavras = new List<string>();                

                // Vamos indicar a próxima posição a ler.
                posicao_da_proxima_leitura = 0;
                for (;;)
                {
                    try
                    {


                        // Serve para guarda a próxima lista de palavras criadas, quando, termina o processamento
                        // iremos apontar a variável 'proxima_lista_de_palavras' para 'lista_de_palavras'.
                        contagem_de_linha = 0;
                        bool gravar_arquivo = false;

                        // Indica a próxima posição a ler, estamos utilizando isto, pois, abrimos o mesmo arquivo
                        // para leitura e gravação.
                        arquivo_proximo_ler.BaseStream.Position = posicao_da_proxima_leitura;
                        var strArquivo_Proximo = arquivo_proximo_ler.ReadLine();
                        posicao_da_proxima_leitura = arquivo_proximo_ler.BaseStream.Position;

                        // Vamos verificar se o arquivo existe.
                        if (!File.Exists(strArquivo_Proximo))
                        {
                            MessageBox.Show("Arquivo não existe: " + strArquivo_Proximo, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Ler todo o conteúdo do arquivo e colocar em lista_de_palavras
                        StreamReader arquivo_proximo_stream = new StreamReader(strArquivo_Proximo, Encoding.UTF8);
                        if (arquivo_proximo_stream.EndOfStream)
                        {
                            MessageBox.Show("Arquivo está vazio: " + strArquivo_Proximo, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        lista_de_palavras.Clear();
                        // Ler cada linha e coloca em lista de palavras.

                        while (!arquivo_proximo_stream.EndOfStream)
                        {
                            lista_de_palavras.Add(arquivo_proximo_stream.ReadLine());
                            if (chkLog_Visivel.Checked)
                            {
                                log_geracao.Text = "Lendo arquivo: " + strArquivo_Proximo + ", linhas lidas: " +
                                                    string.Format("{0:D10}", lista_de_palavras.Count);
                            }
                        }

                        arquivo_sendo_lido = strArquivo_Proximo;

                        // Vamos verificar a quantidade de palavras encontradas, se for maior que a quantidade
                        // de linhas no arquivo informada pelo usuário, há algo errado.
                        if (lista_de_palavras.Count > qt_maxima_de_linhas_no_arquivo)
                        {
                            MessageBox.Show("A quantidade de linhas no arquivo é maior que a quantidade de linhas informada.");
                            return;
                        }

                        // O loop abaixo cria uma nova palavra utilizando a palavra lida do arquivo e cada caractere que o usuário deseja.
                        contador_de_palavras = 0;
                        foreach (var strPalavra in lista_de_palavras)
                        {

                            foreach (var caractere in caracteres_selecionados.ToArray())
                            {
                                // Se o usuário clicou em Parar, a variável abaixo foi definida para true.
                                if (this.bInterromper_geracao)
                                {
                                    return;
                                }

                                var strNova_Palavra = strPalavra + caractere.ToString();

                                // Se a nova palavra gerada é maior que a quantidade de caracteres por palavra, terminar então.
                                if (strNova_Palavra.Length > caracteres_por_palavra)
                                {
                                    arquivo_proximo_gravar.Close();
                                    arquivo_proximo_ler.Close();
                                    arquivo_ja_lido_stream.Close();

                                    MessageBox.Show("Executado com sucesso!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                    // Retornar ao diretório anterior
                                    strDiretorio = strDiretorio_anterior;
                                    return;
                                }

                                quantidade_de_caracteres = strNova_Palavra.Length;
                                proxima_lista_de_palavras.Add(strNova_Palavra);

                                if (++contador_de_palavras == qt_maxima_de_linhas_no_arquivo)
                                {
                                    contador_de_palavras = 0;

                                    Gerar_Nome_de_Arquivo();
                                    Gravar_Conteudo_no_Arquivo();
                                    Gravar_Arquivo_Lido_Arquivo_Gerado("PARCIAL");
                                }

                                // Se o usuário deseja exibir o status.
                                if (chkLog_Visivel.Checked)
                                {
                                    var strTexto_do_log = string.Format("Qt. de arquivos: {0:D10}, ", contador_de_arquivos);
                                    strTexto_do_log += string.Format("Qt. de palavras: {0:D10}, ", contador_de_palavras);
                                    strTexto_do_log += "palavra gerada: '" + strNova_Palavra + "', ";
                                    strTexto_do_log += "cmb: " + string.Format("Qt. de palavras: {0:D10}.", strNova_Palavra.Length);
                                    log_geracao.Text = strTexto_do_log;

                                }


                            }

                        }

                        // Toda vez que lemos um arquivo, todas as palavras de cada linha deve ter a mesma quantidade de caracteres.
                        // Toda vez que um arquivo é gerado, a quantidade de caracteres de uma palavra de cada linha é um caractere
                        // maior, que a linha correspondente de onde este arquivo foi lido.
                        // Então, quando terminamos de ler um arquivo por completo, temos que garantir que as palavras que ainda
                        // não forem gravadas, sejam gravadas independente de a quantidade de palavras máxima por arquivo for 
                        // atingida.
                        // Este procedimento é realizado pois garante que cada arquivo gerado terá sempre em cada linha, palavras
                        // com a mesma quantidade de caracteres.

                        if (contador_de_palavras != 0)
                        {
                            contador_de_palavras = 0;

                            Gerar_Nome_de_Arquivo();
                            Gravar_Conteudo_no_Arquivo();
                            Gravar_Arquivo_Lido_Arquivo_Gerado("INTEGRAL");
                        }



                        // Vamos apontar 'proxima_lista_de_palavras' para 'lista_de_palavras';
                        lista_de_palavras.Clear();
                        proxima_lista_de_palavras.Clear();

                        if (bInterromper_geracao)
                            break;

                        //if (++quantidade_de_caracteres > caracteres_por_palavra)
                        //    break;

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Erro" + exc.Message);
                    }
                }

                Fechar_Arquivo();

                // Vamos retornar ao diretório original.
                strDiretorio_atual = strDiretorio_anterior;

                if (bInterromper_geracao)
                    MessageBox.Show("Cancelado por solicitação do usuário!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("Executado com sucesso!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                // Aqui, como estamos geralmente, trabalhando com somente um thread não terá problema nenhuma.
                // Nós criamos o thread, simplesmente, para evitar que a tela fique travada.
                this.btnParar.Enabled = false;
                this.btnGerar.Enabled = true;

            }
            catch(Exception exc)
            {
                MessageBox.Show("Erro: " + exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Fechar_Arquivo()
        {
            arquivo_proximo_gravar.Close();
            arquivo_proximo_ler.Close();
            arquivo_lido_arquivo_gerado.Close();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCompleto"> 
        ///     Indica "PARCIAL" se o arquivo foi lido parcialmente e gerou um novo arquivo pois a quantidade máxima de palavras
        ///     geradas foi atingidas. 
        ///     Será "INTEGRAL" se o arquivo foi lido completamente.
        /// </param>
        private void Gravar_Arquivo_Lido_Arquivo_Gerado(string strCompleto)
        {
            string strTexto = strCompleto + ";" + arquivo_sendo_lido + ";" + arquivo_gerado;
            arquivo_lido_arquivo_gerado.WriteLine(strTexto);
        }

        /// <summary>
        ///     Gera o nome do arquivo.
        /// </summary>
        private void Gerar_Nome_de_Arquivo()
        {
            contador_de_arquivos++;
            arquivo_gerado = strData_Hora + "_palavra_arq_";
            arquivo_gerado += string.Format("{0:D10}", contador_de_arquivos);
            arquivo_gerado += "_cmb_" + string.Format("{0:D2}", quantidade_de_caracteres);
            arquivo_gerado += "_criado_em_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss_fff");
            arquivo_gerado += ".txt";
            arquivo_gerado = Path.Combine(strDiretorio_atual, arquivo_gerado);
        }

        /// <summary>
        ///     Grava o conteúdo da lista_de_palavras que foi recentemente gerada.
        /// </summary>
        private void Gravar_Conteudo_no_Arquivo()
        {
            // Vamos criar o nome do arquivo.
            StreamWriter arquivo_gerado_stream = new StreamWriter(arquivo_gerado);

            // Vamos gravar todas as palavras encontradas, neste arquivo que criamos.
            long qt_de_palavras = 0;
            foreach (var strPalavra_Gerada in proxima_lista_de_palavras)
            {
                arquivo_gerado_stream.WriteLine(strPalavra_Gerada);
                qt_de_palavras++;

                if (chkLog_Visivel.Checked)
                {
                    log_geracao.Text = "Gravando: '" + strPalavra_Gerada + "', no arquivo " + arquivo_gerado + ", " +
                                        string.Format("{0:D10}", qt_de_palavras) + " de " + proxima_lista_de_palavras.Count.ToString();
                }
            }

            arquivo_gerado_stream.Close();

            // Vamos apagar o conteúdo das palavras geradas.
            proxima_lista_de_palavras.Clear();

            // Vamos guardar o nome do arquivo que acabou de ser criado e que ainda será processado.
            // Vamos definir também a posição da próxima gravação pois o arquivo foi aberto para leitura e gravação.
            arquivo_proximo_gravar.BaseStream.Position = posicao_da_proxima_gravacao;
            arquivo_proximo_gravar.WriteLine(arquivo_gerado);
            arquivo_proximo_gravar.Flush();
            posicao_da_proxima_gravacao = arquivo_proximo_gravar.BaseStream.Position;
        }

        private static string strLetra_Numeros = "abcdefghijklmnopqrstuvwxyz12345678901234567890-=";
        Random numero_aleatorio = new Random((int)DateTime.Now.Ticks);


        /// <summary>
        ///     Cada listBox guarda um tipo de caractere, a função adiciona o caractere no listBox correspondente.
        /// </summary>
        private void Carregar_ListBox()
        {
            Font fonte_mono = new Font("Consolas", 9);
            lskDigitos.Font = fonte_mono;
            lskMaiuscula.Font = fonte_mono;
            lskMinuscula.Font = fonte_mono;
            lskPontuacao.Font = fonte_mono;
            lskSimbolo.Font = fonte_mono;
            lskMinuscula_az.Font = fonte_mono;
            lskMaiuscula_az.Font = fonte_mono;

            // Vamos preencher cada listbox conforme o tipo de letra.
            // Se o caractere for de controle não iremos colocar no listbox.

            for(var iA = 32; iA <= 255; iA++)
            {
                char caractere = (char)iA;

                // Se é um caractere de controle, continuar no próximo caractere.
                if (char.IsControl(caractere))
                    continue;

                string strTexto = caractere.ToString();
                strTexto += ", ASC=" + string.Format("{0:D3}", iA);
                strTexto += ", HEX=" + string.Format("{0:X02}", iA);

                // Agora, iremos distribuir os caracteres no listbox, conforme o tipo do caractere.                                
                if (char.IsDigit(caractere))
                    lskDigitos.Items.Add(strTexto);

                if (char.IsSymbol(caractere))
                    lskSimbolo.Items.Add(strTexto);

                if (char.IsPunctuation(caractere))
                    lskPontuacao.Items.Add(strTexto);


                if (char.IsLetter(caractere))
                {
                    if (caractere >= 'a' && caractere <= 'z')
                        lskMinuscula_az.Items.Add(strTexto);
                    if (caractere >= 'A' && caractere <= 'Z')
                        lskMaiuscula_az.Items.Add(strTexto);

                    // Se é diferente das letras no intervalo a-z e A-Z.
                    if(!(caractere >= 'a' && caractere <= 'z') && !(caractere >= 'A' && caractere <= 'Z'))
                    {
                        if (char.IsLower(caractere))
                            lskMinuscula.Items.Add(strTexto);
                        else
                            lskMaiuscula.Items.Add(strTexto);
                    }

                }



            }

    


        }



        public Form1()
        {
            InitializeComponent();

            Carregar_ListBox();

            // Definir mensagem iniciar para o label 'rotulo_dos_caracteres'
            rotulo_dos_caracteres.Text = "<Selecione os caracteres na lista abaixo.>";
            rotulo_dos_caracteres.ForeColor = Color.Red;
            upCaracteres_por_Palavra.Value = caracteres_por_palavra;
            log_geracao.Font = new Font("consolas", 12);
            log_geracao.Text = "";

            strDiretorio_atual = Directory.GetCurrentDirectory();
            strDiretorio_anterior = strDiretorio_atual;
            txtDiretorio.Text = Directory.GetCurrentDirectory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Botão parar deve estar desativado pois não foi executado nenhum Thread ainda.
            btnParar.Enabled = false;

            upLinhas_por_Arquivo.Value = 1000000;
            upCaracteres_por_Palavra.Value = 10;
            //txtCaracteres_Selecionados.Text = caracteres_selecionados;
            rotulo_dos_caracteres.Text = caracteres_selecionados;
        }

        private void checkBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Se o checkBox foi alterado para o estado true, iremos inserir o caractere encontrado
            // na variável: caracteres_selecionados.
            
            CheckedListBox listBox_Temporario = (CheckedListBox)sender;
            string texto_selecionado = listBox_Temporario.Text;

            if (string.IsNullOrEmpty(texto_selecionado))
                return;

            char caractere = texto_selecionado.ElementAt(0);


            if (e.NewValue == CheckState.Checked)
            {
                // Se o valor é true, quer dizer, que o caractere foi selecionado.
                // Então, iremos inserir este caractere na variável: caracteres_selecionados.

                // Se o caractere não existe, inserir em caracteres_selecionados.
                if(caracteres_selecionados.IndexOf(caractere)== -1)
                {
                    caracteres_selecionados += caractere;
                }
            }
            // O caractere foi deselecionado, retirar tal caractere, se houver, localizado em
            // caracteres_selecionados.
            else
            {
                caracteres_selecionados = caracteres_selecionados.Replace(caractere.ToString(), "");
            }

            exibir_caracteres();
            //txtCaracteres_Selecionados.Text = caracteres_selecionados;
        }

        private void exibir_caracteres()
        {
            // Se a caixa de combinação de ordem ascii está ativada, ordenar os números conforme ascii.
            if(chkOrdenar_Ascii.CheckState == CheckState.Checked)
            {
                bool[] bSelecionado = new bool[256];

                // No loop abaixo, iremos verificar se o caractere foi selecionado.
                foreach(var caractere in caracteres_selecionados.ToCharArray())
                {
                    bSelecionado[(int)caractere] = true;
                }

                // No loop abaixo, a variável 'caracteres_selecionados', terá os caracteres dispostos
                // conforme ordem ascii.
                caracteres_selecionados = "";
                for (int iA = 0; iA < bSelecionado.Length; iA++)
                    if (bSelecionado[iA])
                        caracteres_selecionados += (char)iA;
                
            }
            
            rotulo_dos_caracteres.Text = caracteres_selecionados;
            rotulo_dos_caracteres.Text += "\n(" + caracteres_selecionados.Length + " caracteres)";
        }

        /// <summary>
        ///     Este método altera a propriedade 'Checked' para true de cada ítem do controle CheckedListBox.
        ///     abaixo de cada controle CheckedListBox.
        /// </summary>
        /// <param name="sender">O controle CheckedListBox onde todos os ítens terão o estado Checked para true.</param>
        /// 
        private void marcar_todos(CheckedListBox sender)
        {
            CheckedListBox listBox_temporario = (CheckedListBox)sender;

            int total_de_itens = listBox_temporario.Items.Count;
            for (var iA = 0; iA < total_de_itens; iA++)
            {
                listBox_temporario.SetItemChecked(iA, true);

                char caractere = listBox_temporario.Items[iA].ToString().ElementAt(0);

                // Vamos inserir o caractere em "caracteres_selecionados" se ele não existir.
                if (caracteres_selecionados.IndexOf(caractere) == -1)
                    caracteres_selecionados += caractere;

            }

            exibir_caracteres();
        }

        private void desmarcar_todos(CheckedListBox sender)
        {
            CheckedListBox listBox_temporario = (CheckedListBox)sender;

            int total_de_itens = listBox_temporario.Items.Count;
            for (var iA = 0; iA < total_de_itens; iA++)
            {
                listBox_temporario.SetItemChecked(iA, false);

                char caractere = listBox_temporario.Items[iA].ToString().ElementAt(0);

                // Vamos apagar o caractere se ele não existe.
                if(caracteres_selecionados.IndexOf(caractere) != -1)
                    caracteres_selecionados = caracteres_selecionados.Replace(caractere.ToString(), "");
                
            }
            exibir_caracteres();
        }


        private void btnMarcar_Digitos_Click_1(object sender, EventArgs e)
        {
            marcar_todos(lskDigitos);
        }

        private void btnMarcar_Minuscula_Click(object sender, EventArgs e)
        {
            marcar_todos(lskMinuscula);
        }

        private void btnMarcar_Maiuscula_Click(object sender, EventArgs e)
        {
            marcar_todos(lskMaiuscula);
        }

        private void btnMarcar_Simbolo_Click(object sender, EventArgs e)
        {
            marcar_todos(lskSimbolo);
        }

        private void btnMarcar_Pontuacao_Click(object sender, EventArgs e)
        {
            marcar_todos(lskPontuacao);
        }

        private void btnDesmarcar_Digito_Click(object sender, EventArgs e)
        {
            desmarcar_todos(lskDigitos);
        }

        private void btnDesmarcar_Minuscula_Click(object sender, EventArgs e)
        {
            desmarcar_todos(lskMinuscula);
        }

        private void btnDesmarcar_Maiuscula_Click(object sender, EventArgs e)
        {
            desmarcar_todos(lskMaiuscula);
        }

        private void btnDesmarcar_Simbolo_Click(object sender, EventArgs e)
        {
            desmarcar_todos(lskSimbolo);
        }

        private void btnDesmarcar_Pontuacao_Click(object sender, EventArgs e)
        {
            desmarcar_todos(lskPontuacao);
        }

        private void btnMarcar_Minuscula_az_Click(object sender, EventArgs e)
        {
            marcar_todos(lskMinuscula_az);
        }

        private void btnDesmarcar_Minuscula_az_Click(object sender, EventArgs e)
        {
            desmarcar_todos(lskMinuscula_az);
        }

        private void btnMarcar_Maiuscula_az_Click(object sender, EventArgs e)
        {
            marcar_todos(lskMaiuscula_az);
        }

        private void btnDesmarcar_Maiuscula_az_Click(object sender, EventArgs e)
        {
            desmarcar_todos(lskMaiuscula_az);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            // Se não há caracteres retornar com um erro.
            if(caracteres_selecionados.Length == 0)
            {
                MessageBox.Show("Nenhum caractere selecionado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnGerar.Enabled = false;
            btnParar.Enabled = true;
            thread_de_palavras = new Thread(new ThreadStart(Gerar_Palavras));
            thread_de_palavras.Start();

            //btnGerar.Enabled = false;
            //backgroundWorker1.RunWorkerAsync();
        }


        /// <summary>
        ///  fabiuz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            dlgDiretorio.SelectedPath = Directory.GetCurrentDirectory();
            if (dlgDiretorio.ShowDialog() == DialogResult.OK)
            {
                strDiretorio_selecionado  = dlgDiretorio.SelectedPath;
                txtDiretorio.Text = strDiretorio_selecionado;
            }

            
        }

        private void upLinhas_por_Arquivo_ValueChanged(object sender, EventArgs e)
        {
            linhas_por_arquivo = (int)upLinhas_por_Arquivo.Value;
        }

        private void upCaracteres_por_Palavra_ValueChanged(object sender, EventArgs e)
        {
            caracteres_por_palavra = (int) upCaracteres_por_Palavra.Value;
        }

        private void chkOrdenar_Ascii_CheckedChanged(object sender, EventArgs e)
        {
            exibir_caracteres();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                Gerar_Palavras();
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            palavras_info informacao_das_palavras = (palavras_info)e.UserState;
            //log_geracao.Text = informacao_das_palavras.strPalavra;
            //log_geracao.Refresh();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnGerar.Enabled = true;
            btnParar.Enabled = false;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desejar interromper a geração.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.Yes)
            {
                bInterromper_geracao = true;
                // Ativar e desativar controles.
                btnGerar.Enabled = true;
                btnParar.Enabled = false;
                if (thread_de_palavras.IsAlive)
                {
                    thread_de_palavras.Suspend();
                    thread_de_palavras.Interrupt();
                }
            }
        }

        //private void txtCaracteres_Selecionados_TextChanged(object sender, EventArgs e)
        //{
        //    caracteres_selecionados = txtCaracteres_Selecionados.Text;
        //    exibir_caracteres();
        //}

        private void txtDiretorio_TextChanged(object sender, EventArgs e)
        {
            strDiretorio_selecionado = txtDiretorio.Text;
        }


        private void btnAbrir_Diretorio_Click(object sender, EventArgs e)
        {
            dlgDiretorio.SelectedPath = Directory.GetCurrentDirectory();
            if (dlgDiretorio.ShowDialog() == DialogResult.OK)
            {
                strDiretorio_selecionado = dlgDiretorio.SelectedPath;
                txtDiretorio.Text = strDiretorio_selecionado;
            }
        }
    }

    public class palavras_info
    {
        public string strPalavra;
        public UInt64 quantidade_de_palavras;
    }


}
