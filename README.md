# CadastroCliente

Api Web Cadastro de Pessoas

Ferramentas
- framework .Net Core 5
- framework Angular 11.2
- MySql server
- Visual Studio
-Visual Studio Code

Configurando Ambiente

1- Clonar o reposirório do git:
Crie o repositório local D:\workspace\CadastroCliente, em seguida, abra-o no terminal e clone o projeto com o comando: git clone https://github.com/cesarcarbonecarneiro/CadastroCliente.git

2- Banco de dados:
Criar o banco de dados no MySql server
server=localhost
port=3306
database=cadastro_db
user=root
password=root

3- Buildar a Api
No Visual Studio abrir a solution D:\workspace\CadastroCliente\CadastroCliente\CadastroPessoaBack\CadastroPessoaBack.sln e em seguida buildar a aplicação com o comando Crtl+Shift+B
Abrir o terminal do gerenciador de pacotes Nugets e atualizar o banco de dados com o comando: update-database

4- Interface da Api
No Visual Studio Code, abrir o caminho D:\workspace\CadastroCliente\CadastroCliente\CadastroFront, em seguida, iniciar o comando ng serve.


