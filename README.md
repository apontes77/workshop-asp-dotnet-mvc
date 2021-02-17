# workshop-asp-dotnet-mvc

## Resumo
Esta aplicação foi criada com o auxílio do prof. Nelio Alves por meio de seu curso de C# na plataforma Udemy.
Trata-se de uma simulação de CRUD de dados de vendedores de diversos departamentos. É um caso anêmico de negócio
para pôr em prática o uso do ambiente .NET e da linguagem C#.

### Quanto ao Banco de Dados
Usei Docker para base de dados de teste.
Se você quiser fazer o mesmo, basta fazer o seguinte (estou assumindo que você tenha o Docker devidamente instalado em seu sistema operacional):
* Primeiro, você tem que habilitar o login no Docker Hub no terminal:
> docker login —username:<seu_username_aqui>

* Aí você coloca sua senha e pronto. Depois, você puxa uma imagem do MySQL existente no docker hub, com o comando
> docker pull mysql/mysql:server

* Após isso, use este comando para executar o container do banco em background, com roteamento de portas e configuração básica de usuário MySQL:
> docker run -d -p 3306:3306 -e MYSQL_ROOT_PASSWORD=123 -e MYSQL_DATABASE=teste -e MYSQL_USER=apontes -e MYSQL_PASSWORD=123 id_container
onde id_container é o id do container criado a partir da imagem do segundo comando listado aqui.

* Finalmente, utilize este comando para usar o container com shell interativo:
> docker exec -it name_container /bin/bash

