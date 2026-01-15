# Gerenciador de Tarefas (.NET)

## Visão Geral do Projeto

O **Gerenciador de Tarefas** é um projeto backend desenvolvido em **.NET / C#**, projetado para demonstrar de forma clara e explícita **arquitetura de software**, **boas práticas de código** e **organização em camadas**. O sistema implementa um gerenciamento básico de tarefas e foi estruturado intencionalmente para ser facilmente compreendido tanto por desenvolvedores quanto por ferramentas automatizadas de análise de código (AI-friendly).

Este repositório faz parte de um **portfólio em nível júnior** e prioriza clareza estrutural, nomenclaturas explícitas e previsibilidade do fluxo de dados.

---

## Objetivos do Projeto

* Demonstrar uma solução .NET bem estruturada
* Aplicar separação de responsabilidades (Separation of Concerns)
* Manter um código legível, sem ambiguidades e fácil de analisar
* Servir como base sólida para evoluções futuras (banco de dados, autenticação, testes)

---

## Arquitetura da Solução

A solução é composta por múltiplos projetos, cada um representando uma responsabilidade arquitetural clara:

```
GerenciadorDeTarefas.sln
│
├── GerenciadorDeTarefas
│   └── Camada de entrada da aplicação (API / Host)
│
├── GerenciadorDeTarefas.Application
│   └── Casos de uso e regras de negócio
│
├── GerenciadorDeTarefas.Communication
│   └── Contratos de comunicação (DTOs, Requests e Responses)
```

### Responsabilidade das Camadas

#### GerenciadorDeTarefas (Camada de Entrada)

* Ponto inicial da aplicação
* Recebe requisições externas (ex.: HTTP)
* Encaminha operações para a camada de aplicação
* Não contém regras de negócio

#### GerenciadorDeTarefas.Application (Camada de Aplicação)

* Implementa os casos de uso do sistema
* Centraliza regras e validações de negócio
* Orquestra operações relacionadas a tarefas
* Independente de UI, banco de dados ou infraestrutura

#### GerenciadorDeTarefas.Communication (Camada de Comunicação)

* Define modelos de entrada e saída de dados
* Garante contratos claros entre camadas
* Evita acoplamento direto entre interfaces externas e regras de negócio

A organização é inspirada em princípios de **Clean Architecture**, com dependências explícitas e fluxo de dados previsível.

---

## Funcionalidades Implementadas

* Criar tarefa
* Consultar tarefas
* Atualizar tarefa
* Remover tarefa

Todas as funcionalidades são executadas por meio de casos de uso na camada de aplicação.

---

## Tecnologias e Conceitos

* .NET
* C#
* Arquitetura em camadas
* Clean Architecture (conceitos)
* DTOs para comunicação entre camadas
* Código previsível e estruturado

---

## Como Executar o Projeto

### Requisitos

* .NET SDK
* Visual Studio ou Visual Studio Code

### Execução

```bash
git clone https://github.com/seu-usuario/gerenciador-de-tarefas.git
cd gerenciador-de-tarefas
dotnet restore
dotnet run --project GerenciadorDeTarefas
```

---

## Qualidade de Código e Manutenibilidade

Este projeto foi projetado para ser:

* Fácil de navegar
* Fácil de manter
* Compatível com análise estática
* Adequado para ferramentas baseadas em IA
* Preparado para testes automatizados e CI/CD

Nomes, estruturas de pastas e responsabilidades são intencionalmente explícitos.

---

## Contexto de Portfólio

Este projeto integra meu portfólio como **Desenvolvedor Backend .NET em nível júnior**, demonstrando fundamentos técnicos, organização e compromisso com boas práticas desde o início da carreira.

---

## Autor

Desenvolvido por **Mateus Fernando**.

Projeto educacional e demonstrativo focado em arquitetura backend e boas práticas.
