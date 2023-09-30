# Sistema de Reservas de Suítes de Hotel

Este é um programa simples em C# que simula um sistema de reservas de suítes de hotel. Ele permite cadastrar hóspedes, suítes e calcular o valor da diária com desconto.

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download/dotnet) instalado em sua máquina.

## Como Usar

1. Clone este repositório em sua máquina:

   ```shell
   git clone https://github.com/HudDavi/CSharp-Hotel.git
   ```

2. Navegue até o diretório do projeto:

   ```shell
   cd CSharp-Hotel
   ```

3. Compile o projeto:

   ```shell
   dotnet build
   ```

4. Execute o programa:

   ```shell
   dotnet run
   ```

5. Você verá a saída no console com informações sobre a quantidade de hóspedes e o valor da diária calculado.

## Estrutura do Projeto

- `Program.cs`: Este é o ponto de entrada do programa. Ele cria instâncias de pessoas, suítes e uma reserva e exibe informações no console.

- `Pessoa.cs`: Esta classe representa uma pessoa (hóspede) com propriedades como nome e sobrenome.

- `Reserva.cs`: Esta classe é responsável por gerenciar reservas de suítes de hotel. Ela permite cadastrar hóspedes, suítes e calcular o valor da diária com desconto.

- `Suite.cs`: Esta classe representa uma suíte de hotel com propriedades como tipo de suíte, capacidade e valor da diária.

## Contribuição

Sinta-se à vontade para contribuir com este projeto, abrindo problemas ou enviando solicitações de recebimento (pull requests).

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).