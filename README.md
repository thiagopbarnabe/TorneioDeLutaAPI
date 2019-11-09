# TorneioDeLutaAPI
Api do projeto torneio de luta feita em AspNet Core Api 3.0 

Para rodar este projeto basta clonar o respositorio em sua maquina e compilar e executar com o visual studio. /
Atente se para a configuração de portas/
Ficou convencionado o uso da porta https://localhost:5001;http://localhost:5000 para a api e http://localhost:8080" para a UI caso altere
a porta do UI não se esqueça de alterar tambem dentro da configuração do CORS dentro do startup 
app.UseCors(builder => builder
                .WithOrigins("http://localhost:8080")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()
            );
            
caso contrario as aplicações não vão funcionar na mesma maquina. 

Caso altere a porta da API não esqueça de configurar tambem a UI (https://github.com/thiagopbarnabe/TorneioDeLutaUI)

Para a criação dos testes unitarios foi criado um projeto chamado TorneioDeLuta.UnitTest utilizando xUnit. Com a propria interface do 
visual studio é possivel realizar os testes. Para isto basta clicar em cima do projeto com o botão direto clicar em Run Tests.
Nem todas as classes de dominio possuem testes por questão de tempo apertado. Mas algumas foram criadas para exemplificar. Mesmo estas
não estão completas. O intuito do projeto é demonstrar conhecimento e não criar uma aplicação.

Considerações Finais:
Para este projeto foi feita a criação de uma estrutura DDD. Não esta completo, durante o desenvolvimento varias ideias de melhorias e 
refactoring foram surgindo mas o tempo é restrito portanto resolvi deixar como esta. Tentei usar o maior numero de tecnologias e boas 
praticas possiveis. 

Qualquer duvida favor entrar em contato.
