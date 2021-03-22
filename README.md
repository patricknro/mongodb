# MongoDB
Gravar e fazer leitura dos dados (usando Docker)


### Link do Tutorial
- https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-3.1&tabs=visual-studio

### Instalar o Nuget Package abaixo (MongoDB.Driver)
- https://www.nuget.org/packages/MongoDB.Driver/

### Imagem do Docker utilizado
- `> docker run --name <nome_container> -p <porta_interna_container>:<porta_externa> -d mongo:<versao>`

*_A porta interna e externa utilizada foi 27017_

### Aplicação para gerenciar o MongoDB foi utilizado o abaixo.
- Robo 3T 1.4.3 (Build 48f7dfde - 3/2021)


#cURL

### Gravar log
```
curl --location --request POST 'http://localhost:63350/api/log/gravar' \
--header 'Content-Type: application/json' \
--data-raw '{
    
    "bookName": "Teste",
    "price": 99.99,
    "category": "Beans",
    "author": "Patrick Nascimento"
}'
```

### Ler o log
```
curl --location --request GET 'http://localhost:63350/api/log/obter-log/60580686a37ad0aa92f94da5'
```