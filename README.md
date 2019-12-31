# DesafioXamarin

# Solução: 

No começo houve uma fase de estudos, para usar o Xamarin Forms. Depois disso, fiz uma listview básica para testar seu funcionamento. Aprendendo isso, criei as classes necessárias para o funcionamento da API e fiz o acesso a API proposta para o programa, a partir daí foi feito a manipulação dos dados com o objetivo de criar uma listview na página 1.

A página 2 só foi alterado o agrupamento dos dados em vez de ser por ordem alfabética, como na página 1, foi organizado por regiões brasileiras.

Para a página 3 houve a escolha do SQLite para a solução, por conta de sua integração com o c#, nessa fase ocorre a criação de uma classe da tabela para o SQLite, criação dos comandos necessários para a manipulação do banco de dados, assim sendo, houve um novo acesso a API proposta e os dados recebidos foram inseridos no banco e dele foi criada uma listview que apresenta todos os estados. 

Não foi utilizada framework de terceiros para a arquitetura MVVM, foram utilizadas as bibliotecas sqlite-net-pci, para tratar o banco de dados SQLite e PCLExt.FileStore para acessar arquivos locais necessários para manipular o banco de dados, foi utilizado o Android 9 durante os testes.
