# Sistema de Controle de Clientes

## Descrição
Este sistema é uma aplicação em console desenvolvida em C# para gerenciar informações de clientes, seja Pessoa Física ou Pessoa Jurídica, calculando impostos e total a pagar baseado no valor de compra informado pelo usuário.

## Funcionalidades
- Cadastro de cliente com nome e endereço.
- Distinção entre Pessoa Física e Pessoa Jurídica com campos específicos para cada uma:
  - Pessoa Física: CPF e RG.
  - Pessoa Jurídica: CNPJ e IE (Inscrição Estadual).
- Cálculo de imposto diferenciado:
  - Pessoa Física: 10% sobre o valor de compra.
  - Pessoa Jurídica: 20% sobre o valor de compra.
- Exibição do valor de compra, valor do imposto e total a pagar.

## Entrada de Dados
O usuário será solicitado a fornecer:
- Nome
- Endereço
- Tipo de cliente (Pessoa Física ou Jurídica)
- CPF ou CNPJ
- RG ou IE
- Valor de compra

## Saída de Dados
O sistema irá processar as informações e exibirá:
- Nome
- Endereço
- CPF/CNPJ
- RG/IE
- Valor de Compra
- Imposto calculado
- Total a pagar
