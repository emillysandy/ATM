## Desafio Caixa Eletrônico

### Requisitos:

- Deve ser desenvolvido completamente Orientado a Objetos utilizando as melhores práticas dos 4 pilares de Orientação a Objetos: Herança, Abstração, Polimorfisto e Encapsulamento.
- Utilizar Generalização, Interface para assinatura de comportamentos (somente metodos).
- Função Deposito: 1) deve ser possivel depositar notas de R$ 10,00 / R$ 20,00 / R$  50,00 / R$  100,00 / R$  e 200,00 para Real(BRL) e moedas de R$ 0,01, R$ 0,05 /  R$ 0,10 / R$ 0,25 / R$ 0,50 / R$ 1,00 para Real(BRL).     2) deve ser possível depositar notas de $2, $5, $10, $20, $50 e $100 Dollar Americano (USD) e moedas  $0.01 / $0.05 / $0.10 /$0.25 /$0.50 /$1.00 Dollar Americano (USD).
- O caixa eletronico deve registrar a cotação de cambio do dia para conversão de moedas.
- O caixa eletrônico deve dar troca na moeda original não convertida no cambio. Por exemplo: Ao depositar real e sacar dollar, o troco deve ser dados em real.
- Caso o caixa eletronico não tenha mais moedas ou notas para entregar como troco, o troco pode ser dados em transfer6encia via PIX, TED ou numa wallet pra o cliente dentro do caixa eletronico em uma conta específica do cliente.
- O cliente deve se cadastrar com os seguintes dados: Nome Completo, CPF, e uma senha de 4 números que nao pode ser 0000 nem 9999 e nem 1111.
- O caixa eletronico deve dar suporte adicional a mais duas moedas e conseguir fazer cambio entre elas. Segue lista, escolhe até duas moedas desta lista: Peso Argentino, Euro, Dollar Canadense, Peso Mexicano,  Lira Turca ou Cedi Ganês.
- O caixa eletronico, alem de cambio deve permitir funcoes somente Saque, Somente Deposito em qualquer moeda.
- Será possível fazer cambio comprando com o cartào de crédito. No caso de compra de moeda com cartão a taxa de Cambio. eh de 8%, onde esse 8% cobrado fica como dinheiro eletronico que pode ser utilizado como troco em operações de PIX e TED.
- Toda operacão tem taxa. Segue: Cambio com Cartão 8%, Deposito 0%, Saque 4,5%, Cambio (compra de moeda utilizando deposito) 6%.
- Toda cobrança de taxa fica para o banco.
- Todas as taxas devem ser convertidas em reais e salva em uma conta específica do banco, ou seja, o banco só salva valores em reais em suas contas bancárias (isso eh uma regra muito forte).
- Será possivel tirar relatórios: Quantas operações foram efetuadas por tipo? Quanto de taxa o banco já tem em sua conta? Qual o valor de saldo em cada conta corrente dos clientes? Quanto tem dentro do caixa eletronico em Notas e Moedas por tipo de Moeda (BRL,USD, etc...)
- O caixa eletronico tem uma opcão de carga de notas e moedas por tipo (BRL,USD, etc.....). Mas tudo tem limite, o caixa eletrônico só pode armazenar 20000 notas e 50000 moedas independente do tipo de moeda.Esse eh um limite de armazenagem físico mesmo.
- As notas e moedas depositadas pelos clientes também podem ser utilizadas para saque, mas cuidado com o limite.