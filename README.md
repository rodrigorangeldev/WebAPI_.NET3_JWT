# Web API .NET3.1 com JWT (Json Web Token )
Exemplo de Web API em .NET 3 com JWT (Json Web Token), seguindo tutorial do site André Baltieri. https://balta.io/blog/aspnetcore-3-autenticacao-autorizacao-bearer-jwt.

#0 - É necessário ter o dotnet SDK 3.0 ou superior instalado, Visual Studio ou VSCode com a Extensão C# instalada.
#1 - Faça o download / clone do projeto.
#2 - Abra a pasta Shop not seu terminal, execute o comando dotnet watch run. Aguarde a restauração dos pacotes.

#3 - Acesse a rota https: //localhost:5001/v1/account/login para geração do token de acesso, fique atento ao número de porta, o seu pode estar diferente.
#4 - Rotas (Não esqueça de enviar o token no header da requisição):
- https: //localhost:5001/v1/account/anonymous (não precisa de token)
- https: //localhost:5001/v1/account/authenticated
- https: //localhost:5001/v1/account/employee
- https: //localhost:5001/v1/account/manager
