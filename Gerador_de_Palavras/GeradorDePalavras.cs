using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gerador_de_Palavras
{
    [Serializable]
    struct GeradorDePalavrasArquivo
    {
        public int qt_min_de_caracteres;
        public int qt_max_de_caracateres;
        public int qt_total_de_caracteres;
        public char[] caracteres;
        public int[] ultimo_indice_por_posicao;

        /// <summary>
        /// Lista de diretórios, onde os arquivos estão sendo gerados, geralmente, 
        /// ao gerar pela primeira vez, o usuário somente pode escolher um diretório, posteriormente,
        /// ele pode escolher outro diretório, se ele interromper a geração dos arquivos e continuar
        /// da última posição que começou.
        /// </summary>
        public List<string> lista_de_diretorios;

        public UInt64 id_ultimo_arquivo_gerado;
    }

    public enum GeradorDePalavrasStatus
    {
        GERADOR_DE_PALAVRAS_ERROR_AO_VALIDAR_DADOS,
        GERADOR_DE_PALAVRAS_GERANDO_PALAVRAS,
        GERADOR_DE_PALAVRAS_CONCLUIDO_COM_ERRO,
        GERADOR_DE_PALAVRAS_CONCLUIDO_COM_SUCESSO,
        GERADOR_DE_PALAVRAS_INTERROMPIDO_PELO_USUARIO,
    }

    public class GeradorDePalavrasEventArgs : EventArgs
    {
        public UInt64 palavraPosicao;
        public int palavraTamanho;
        public string palavraGerada;

        public GeradorDePalavrasStatus status;
        public string status_msg;

        public GeradorDePalavrasEventArgs() { }

    }

    public class GeradorDePalavras
    {
        // public delegate void GeradorDePalavrasEventHandler(object sender, GeradorDePalavrasEventArgs e);

        //public EventHandler<GeradorDePalavrasEventArgs> GeradorDePalavrasEventHandler;

        public event EventHandler<GeradorDePalavrasEventArgs> GeradorDePalavrasStatusAtual;
        public event EventHandler<GeradorDePalavrasEventArgs> GeradorDePalavrasConcluido;

        private GeradorDePalavrasEventArgs eventArgs = new GeradorDePalavrasEventArgs();

        private CancellationToken cancellationToken;

        public bool exibirStatus = true;

        UInt64 contadorDePalavras;

        int qt_min_de_caracteres;
        int qt_max_de_caracteres;
        int qt_total_de_caracteres;

        // Armazena onde 
        List<string> lista_de_diretorios;

        List<char> lista_de_caracteres = null;

        public GeradorDePalavras(int qt_min_de_caracteres,
            int qt_max_de_caracteres,
            List<char> lista_de_caracteres,
            CancellationToken cancellationToken)
        {
            this.qt_min_de_caracteres = qt_min_de_caracteres;
            this.qt_max_de_caracteres = qt_max_de_caracteres;
            this.qt_total_de_caracteres = lista_de_caracteres.Count;
            this.lista_de_caracteres = lista_de_caracteres;

            this.cancellationToken = cancellationToken;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retorna true, se os dados são validos pra gerar as palavras, 
        /// retorna false caso contrário.</returns>
        private bool validar_dados()
        {
            eventArgs.palavraGerada = "";
            eventArgs.palavraPosicao = 0;
            eventArgs.palavraTamanho = -1;
            eventArgs.status = GeradorDePalavrasStatus.GERADOR_DE_PALAVRAS_ERROR_AO_VALIDAR_DADOS;
            eventArgs.status_msg = "";

            if (qt_min_de_caracteres < 0)
            {
                eventArgs.status_msg = "Quantidade mínima de caracteres deve ser maior que 1.";
                eventArgs.status = GeradorDePalavrasStatus.GERADOR_DE_PALAVRAS_ERROR_AO_VALIDAR_DADOS;
            }

            if (qt_min_de_caracteres > qt_max_de_caracteres)
            {
                eventArgs.status_msg = "Quantidade mínima de caracteres deve ser maior que 1.";
                eventArgs.status = GeradorDePalavrasStatus.GERADOR_DE_PALAVRAS_ERROR_AO_VALIDAR_DADOS;
            }

            if (qt_max_de_caracteres < 0)
            {
                eventArgs.status_msg = "Quantidade máxima de caracteres deve ser maior que 1.";
                eventArgs.status = GeradorDePalavrasStatus.GERADOR_DE_PALAVRAS_ERROR_AO_VALIDAR_DADOS;
            }

            if (lista_de_caracteres.Count <= 0)
            {
                eventArgs.status_msg = "Nenhum caractere foi selecionado.";
                eventArgs.status = GeradorDePalavrasStatus.GERADOR_DE_PALAVRAS_ERROR_AO_VALIDAR_DADOS;
            }

            // Só pode haver até 256 caracteres.
            if (lista_de_caracteres.Count > 256)
            {
                eventArgs.status_msg = "Há mais de 256 caracteres na lista de caracteres.";
                eventArgs.status = GeradorDePalavrasStatus.GERADOR_DE_PALAVRAS_ERROR_AO_VALIDAR_DADOS;
            }

            if (eventArgs.status_msg.Trim() != "")
            {
                return false;
            }

            return true;
            
        }

        public void GerarPalavras()
        {
            if (!validar_dados())
            {
                GeradorDePalavrasStatusAtual?.Invoke(this, eventArgs);
            }

            StringBuilder palavra_gerada = new StringBuilder(qt_max_de_caracteres);

            // Agora, vamos gerar as palavras.
            var indice_coluna_atual = 0;
            var indice_coluna_maxima = qt_max_de_caracteres - 1;

            // Indica o índice da coluna mais a direita, onde devemos capturar os índices
            // pra montar a palavra.
            var indice_ultima_coluna = qt_min_de_caracteres - 1;

            // Cada posição do arranjo 'indice_colunas', conterá um índice de '0'
            // à quantidade de caracteres - 1 da 'lista_de_caracteres'.
            // Então, toda vez que na posição o índice for maior que o maior índice
            // da lista de caracteres, iremos incrementa a próxima coluna, por isto,
            // preciso saber qual é o maior índice.
            var ultimo_indice_caracteres = lista_de_caracteres.Count - 1;

            // Agora, vamos montar um arranjo que vai armazenar os índices 
            var colunas = new int[qt_max_de_caracteres];

            // Aqui, vamos fazer cada posição apontar pra antes do primeiro caractere.
            for (var indice = 0; indice < colunas.Length; indice++)
            {
                colunas[indice] = -1;
            }

            // Devemos começar uma palavra com pelo menos x caracteres, então,
            // vamos apontar pra o primeiro caractere.
            for (var indice = 1; indice <= indice_ultima_coluna; indice++)
            {
                colunas[indice] = 0;
            }

            // Agora, vamos gerar as palavras.
            colunas[0] = -1;
            contadorDePalavras = 0;

            while (indice_coluna_atual <= indice_coluna_maxima)
            {
                colunas[indice_coluna_atual] += 1;

                if (colunas[indice_coluna_atual] > ultimo_indice_caracteres)
                {
                    colunas[indice_coluna_atual] = 0;
                    indice_coluna_atual += 1;

                    if (indice_coluna_atual > indice_ultima_coluna)
                        indice_ultima_coluna += 1;

                    continue;
                }
                indice_coluna_atual = 0;

                // Agora, vamos montar a palavra
                palavra_gerada.Clear();
                for (var indice = 0; indice <= indice_ultima_coluna; indice++)
                {
                    var indice_lista = colunas[indice];
                    palavra_gerada.Append(lista_de_caracteres[indice_lista]);
                }

                eventArgs.palavraGerada = palavra_gerada.ToString();
                eventArgs.palavraTamanho = eventArgs.palavraGerada.Length;
                eventArgs.palavraPosicao = contadorDePalavras++;
                eventArgs.status = GeradorDePalavrasStatus.GERADOR_DE_PALAVRAS_GERANDO_PALAVRAS;

                if (exibirStatus)
                    GeradorDePalavrasStatusAtual?.Invoke(this, eventArgs);

                if (cancellationToken.IsCancellationRequested)
                {
                    eventArgs.status_msg = "Usuário cancelou a geração das palavras.";
                    eventArgs.status = GeradorDePalavrasStatus.GERADOR_DE_PALAVRAS_INTERROMPIDO_PELO_USUARIO;
                    GeradorDePalavrasStatusAtual?.Invoke(this, eventArgs);
                    break;
                }
            }

            eventArgs.status_msg = "Todas as palavras foram geradas.";
            eventArgs.status = GeradorDePalavrasStatus.GERADOR_DE_PALAVRAS_CONCLUIDO_COM_SUCESSO;
            GeradorDePalavrasStatusAtual?.Invoke(this, eventArgs);
            GeradorDePalavrasConcluido?.Invoke(this, eventArgs);


        }
    }
}