# Validador de CPF em C#

Este projeto é um programa em C# que valida números de CPF utilizando a lógica oficial de cálculo dos dígitos verificadores.

## Funcionalidades

- Recebe um CPF informado pelo usuário, com ou sem os caracteres de formatação (pontos e traço).
- Remove os caracteres não numéricos.
- Verifica se o CPF possui exatamente 11 dígitos numéricos.
- Calcula os dois dígitos verificadores com base na regra oficial.
- Informa se o CPF é válido ou inválido.

## Como usar

1. Clone este repositório.
2. Abra o projeto em uma IDE compatível com C# (Visual Studio, Visual Studio Code com extensão C#, etc).
3. Compile e execute.
4. Insira o CPF quando solicitado (pode ser com ou sem formatação).
5. Veja o resultado da validação no console.

## Exemplo de uso
```plaintext
Bem-vindo ao validador de CPF!
Insira o CPF a ser validado:
168.995.350-25
CPF válido!
```

## Observações
Este programa é focado apenas na lógica matemática de validação dos dígitos verificadores.

Não faz verificação contra bases oficiais ou bloqueio de CPFs inválidos, apenas checa o formato e cálculo.
