# Desafio DIO - Trilha .NET - Programação Orientada a Objetos
[www.dio.me](www.dio.me)

## Desafio de Projeto
Este projeto é parte de um desafio proposto pela Digital Innovation One (DIO) como parte da trilha .NET, com foco em Programação Orientada a Objetos.

## Objetivo do Desafio
O principal objetivo deste desafio é aplicar os conceitos de Programação Orientada a Objetos (POO) na modelagem de um sistema que envolve celulares. O desafio requer a criação de uma abstração para representar celulares, permitindo a definição de comportamentos específicos para diferentes marcas e modelos.

## Estrutura do Projeto
O projeto é implementado em .NET, utilizando o tipo de aplicação console. A estrutura inclui:

![Diagrama classes](Imagens/diagrama.png)

**Classe Abstrata Smartphone:**
- Representa a abstração de um smartphone.
- Propriedades para Numero, Modelo, IMEI e Memoria.
- Método `InstalarAplicativo` é abstrato.

**Classes Concretas Nokia e Iphone:**
- Herdam da classe abstrata Smartphone.
- Implementam o método `InstalarAplicativo` refletindo o comportamento específico de instalação de aplicativos para Nokia e iPhone.

**Testes no Console:**
- Cria instâncias de Nokia e Iphone.
- Chama métodos para demonstrar o comportamento específico de cada classe.

## Como Executar
O código pode ser executado em um ambiente .NET, utilizando um ambiente de desenvolvimento integrado (IDE) como Visual Studio ou através do terminal. Certifique-se de ter o ambiente .NET instalado em sua máquina.



```bash
dotnet run
```

## Conclusão
Este projeto é uma demonstração prática da implementação de conceitos fundamentais de Programação Orientada a Objetos em .NET. A estrutura de classes e a herança foram utilizadas para modelar o comportamento de smartphones de diferentes marcas. A conclusão bem-sucedida deste desafio não apenas reforça o entendimento de POO, mas também destaca a capacidade de aplicar esses conceitos em um contexto real de desenvolvimento.

Projeto desenvolvido como parte da trilha .NET da Digital Innovation One (DIO).



