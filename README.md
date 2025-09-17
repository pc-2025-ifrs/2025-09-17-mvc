# 2025-09-17-mvc

Domain Model => Modelo de Domínio

Model => Modelo
View => Ver => Tela => Apresentação => UI (User Interface)
Controller => Controlador

Usuário
    ação =====> Controller =======> Model
retorno da ação <= View <================

## Dois tipos de aplicação Web

1. Server-Side Rendering => Renderizar no lado do servidor
2. Client-Side Rendering => Renderizar no lado do cliente

Cliente   <====>    Servidor
App no Celular                 Local, Intranet, Internet
Site no Navegador              Computador mais "potente"
Aplicativo no Windows          localhost

SPA: Single Page Application
React, Vue.JS, Angular, Svelte, ...

SSR: Servidor devolve HTML
CSR: Cliente recebe do servidor apenas os dados, o cliente cria o HTML

Comando:

dotnet new webapi --use-controllers