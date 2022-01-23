**Gerador de palavras v2.0**

Autor: ***Fábio Moura de Oliveira***

Data da criação:  30/12/2015

Data da postagem no github: 20/06/2016

*Observacao:* `A versao v2.0 não gera arquivo ainda, somente a versão 1.0.
Na versão 1.0, os arquivos determinavam que palavras iriam serem geradas, ou seja, na versão 1, se gerasse
o arquivo 1 e o arquivo 2, por exemplo, o arquivo 3 era gerado utilizando os arquivos 1 e 2.
Na versão 2.0, as palavras são geradas completamente diferente, desta vez, consegui fazer um algoritmo
onde, eu posso gerar palavras com uma quantidade mínima de caracteres e máxima de caracteres, onde
na versão 1.0, eu só poderia determinar a quantidade máxima.`

`A versão 2.0 será muito mais rápida pra gerar as palavras pois na versão 1, por exemplo, vamos supor que
eu escolhi os caracteres "abc", então, no arquivo 1, teria:
a
b
c
No arquivo 2 teria
aa
ab
ac
ba
bb
bc
ca
cb
cc
Pra gerar o arquivo 3, com 3 caracteres, eu utilizava o arquivo 2, pra cada linha, é gerado 3 linhas,
pois eu adicionava os caracteres 'a', 'b' e 'c'.
`

`Na versão 2, você poderá:
* Escolher a quantidade mínima de caracteres que uma palavra poderá ter, na versão 1 isto não existia.
* Escolher a quantidade máxima de caracteres, deve-se ter uma quantidade máxima, não pode ser infinita.
* Continuar a geração das palavras de onde foi interrompido, na versão 1 isto não existia.
`


Objetivo:
Gere todas as combinações possíveis de caracteres, utilizando um ou mais caracteres ascii entre 128 a 255.

`Como utilizar: `
1. Escolha os caracteres, utilizando a guia: *Selector de Caracteres*.

2. Em seguida, vá pra guia "Quantidade de caracteres", e escolha a "quantidade mínima de caracteres", que
	uma combinação pode ter, e escolha, também, a "quantidade máxima de caracteres" que uma combinação
	poderá ter. Observe que o programa gera todas as combinações possíveis, por exemplo, se você escolher
	que uma combinação pode ter entre 2 caracteres e no máximo 4 caracteres, e escolher o caractere, `a` e `b`,
	o programa vai gerar isto:
	aa ab ba bb
	aaa aab aba abb	baa bab bba bbb
	aaaa aaab aaba aabb	abaa abab abba abbb baaa baab baba babb	bbaa bbab bbba bbbb

3. Em seguida, vá pra guia "Gerar" e clique no botão "Gerar".
	Pra interromper o processo, clique em "Parar", uma mensagem perguntará se desejar realmente interromper 
	o processo, se escolher "sim", o procedimento é interrompido.
	Nesta versão 2.0, aínda não foi implementado, continuar de onde parou, principalmente, em geração de combinações
	com muitos caracteres, isto será em breve implementado.


`Recursos a serem implementados:`
. Continuar a geração das combinações de onde parou, principalmente, pra combinações com muitos caracteres.



`Erros Conhecidos`
Em linux, este erro pode ocorrer: 
Resource temporarily unavailable [EWOULDBLOCK].
Solução: Em análise.


