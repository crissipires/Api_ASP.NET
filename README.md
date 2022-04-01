# Api_ASP.NET
Api simples para cadastro de pessoas com intuito de fixar os conceitos iniciais do asp.net

### Documentação da Api via swagger - Url

> https://localhost:5001/swagger/index.html

### Parametros 

```
"components": {
    "schemas": {
      "Pessoa": {
        "type": "object",
        "properties": {
          "id": {
            "type": "integer",
            "format": "int32"
          },
          "nome": {
            "type": "string",
            "nullable": true
          },
          "cidade": {
            "type": "string",
            "nullable": true
          },
          "anoNascimento": {
            "type": "integer",
            "format": "int32"
          }
        }
      }
    }

```
