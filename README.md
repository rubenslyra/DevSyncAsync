# DevSyncAsync

![C#](https://img.shields.io/badge/language-C%23-239120?style=flat-square&logo=csharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=flat-square&logo=visualstudio&logoColor=white)
![License: MIT](https://img.shields.io/badge/license-MIT-yellow?style=flat-square)
![Projects](https://img.shields.io/badge/projetos-3-blue?style=flat-square)
![Status](https://img.shields.io/badge/status-educacional-brightgreen?style=flat-square)

> Solução educacional em C# que demonstra na prática as diferenças entre programação **síncrona** e **assíncrona** usando `async/await`, `Task` e `Task<T>` no .NET Framework 4.8.

---

## 📋 Sobre o Projeto

Este repositório contém três projetos de console que simulam um cenário cotidiano — preparar o café da manhã — para ilustrar, de forma didática, três abordagens diferentes de execução assíncrona em C#:

| Projeto | Abordagem | Descrição |
|---|---|---|
| `DevAssync` | Async sem retorno | `async Task` — executa tarefa em paralelo sem retornar valor |
| `DevAsyncRetorno` | Async com retorno | `async Task<T>` — executa tarefa em paralelo e retorna um valor |
| `DevSync` | Fire-and-forget | `Task.Run()` sem `await` — tarefa disparada sem aguardar conclusão |

O cenário utilizado é: **preparar café** (`PassarCafe`) de forma assíncrona enquanto **torrar o pão** (`TostarPao`) é executado de forma síncrona — ambos acontecendo ao mesmo tempo, como na vida real.

---

## 🗂️ Estrutura da Solução

```
DevSyncAsync/
├── DevAssync/               # Projeto 1 — Async sem retorno (Task)
│   └── Program.cs
├── DevAsyncRetorno/         # Projeto 2 — Async com retorno (Task<int>)
│   └── Program.cs
├── DevSync/                 # Projeto 3 — Fire-and-forget
│   └── Program.cs
├── DevSyncAsync.slnx        # Arquivo de solução (Visual Studio)
└── LICENSE.txt
```

---

## 🚀 Projetos

### 1. DevAssync — Async sem retorno (`Task`)

Demonstra o uso de `async Task` para executar uma tarefa em segundo plano sem retornar valor. O método `PassarCafe()` é iniciado como uma task e executa concorrentemente com `TostarPao()`, que é síncrono. Ao final, o programa aguarda a conclusão do café com `Task.Wait()`.

**Conceitos demonstrados:**
- `async Task` (sem retorno)
- Execução concorrente de tarefas
- `Task.Wait()` para aguardar a conclusão

**Saída esperada (intercalada):**
```
Preparando o café...
Preparando o pão...
...
O café da manhã está na mesa!
```

---

### 2. DevAsyncRetorno — Async com retorno (`Task<T>`)

Evolução do projeto anterior: `PassarCafe()` agora retorna `Task<int>`, informando a quantidade de cafés preparados. Após `Task.Wait()`, o valor é recuperado via `Task.Result` e exibido ao usuário.

**Conceitos demonstrados:**
- `async Task<T>` com retorno de valor
- Recuperação do resultado com `Task.Result`
- Combinação de tarefas síncronas e assíncronas

**Saída esperada:**
```
Preparando o café...
Preparando o pão...
...
O café da manhã está na mesa. Quantidade de cafés entregues no pedido: 10
```

---

### 3. DevSync — Fire-and-forget (`Task.Run` sem await)

Demonstra o padrão **fire-and-forget**: `PassarCafe()` dispara uma task com `Task.Run()` internamente, mas o chamador não aguarda sua conclusão. O programa pode encerrar antes que o café termine de ser preparado — um comportamento problemático e intencional para fins didáticos.

**Conceitos demonstrados:**
- `Task.Run()` sem `await` (fire-and-forget)
- Riscos de tarefas não aguardadas
- Comportamento não determinístico de conclusão

**Saída esperada:**
```
Preparando o pão...
...
O café da manhã está na mesa!
(o café pode não ter sido totalmente preparado)
```

---

## 🛠️ Pré-requisitos

- [Visual Studio 2022+](https://visualstudio.microsoft.com/) ou [.NET Framework SDK 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
- Windows (requerido pelo .NET Framework 4.8)

---

## ▶️ Como executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/rubenslyra/DevSyncAsync.git
   ```

2. Abra a solução `DevSyncAsync.slnx` no Visual Studio.

3. Selecione o projeto desejado como **Projeto de Inicialização**.

4. Pressione **F5** ou clique em **Iniciar** para executar.

---

## 📚 Conceitos Abordados

- `async` / `await` em C#
- `Task` e `Task<T>` do namespace `System.Threading.Tasks`
- Diferença entre código síncrono e assíncrono
- Padrão fire-and-forget e seus riscos
- `Thread.Sleep` vs execução assíncrona

---

## 📄 Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE.txt).
