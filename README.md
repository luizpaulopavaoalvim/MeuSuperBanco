# MeuSuperBanco - Aplicativo de Banco em C# e .NET

## Descrição
Este repositório contém o código-fonte e a documentação para o MeuSuperBanco, um projeto de sistema bancário desenvolvido em C# e .NET. O aplicativo é baseado no console do Visual Studio e oferece uma experiência interativa para gerenciar contas bancárias.

## Recursos Principais
1. **Cadastro de Contas:** Permite a criação e gerenciamento de contas bancárias via console.
2. **Operações Bancárias:** Facilita depósitos e saques através de comandos interativos.
3. **Extrato de Conta:** Gera um extrato detalhado das transações realizadas em uma conta.

## Instruções de Uso
1. Clone o repositório em sua máquina local.
2. Abra o projeto no Visual Studio ou VSCode.
3. Execute o aplicativo e siga as instruções no console para interagir com as funcionalidades do MeuSuperBanco.

## Contribuições
Contribuições são encorajadas! Se encontrar problemas ou tiver ideias para melhorar o aplicativo, sinta-se à vontade para contribuir com o projeto.

## Tecnologias Utilizadas
- Linguagem: C#
- Framework: .NET
- Ambiente de Desenvolvimento: Visual Studio

## Exemplo de Uso
```csharp
// Exemplo de criação de conta
MeuSuperBanco.ContaBanco contaB = new ContaBanco("Luiz Paulo", 10000);
Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criado com o saldo no valor de {contaB.Saldo} reais");

// Exemplo de depósito
contaB.Depositar(300, DateTime.Now, "recebi um pagamento");
Console.WriteLine($"A conta está com {contaB.Saldo} reais");

// Exemplo de saque
contaB.Sacar(800, DateTime.Now, "Fiz as compras");
Console.WriteLine($"A conta está com {contaB.Saldo} reais");







