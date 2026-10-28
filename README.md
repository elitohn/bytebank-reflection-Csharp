<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&height=175&color=0:0F172A,55:164E63,100:0891B2&text=ByteBank%20Reflection&fontColor=FFFFFF&fontSize=34&fontAlignY=38&desc=C%23%20%7C%20.NET%2010%20%7C%20Plugins&descAlignY=61&descSize=15" alt="Capa do projeto ByteBank Reflection" width="100%" />

![Tecnologia](https://img.shields.io/badge/C%23%20%26%20.NET%2010-0F172A?style=flat-square) ![Idioma](https://img.shields.io/badge/documentação-pt--BR-0891B2?style=flat-square) ![Tipo](https://img.shields.io/badge/projeto-de%20estudo-334155?style=flat-square)

</div>

# 🏦 ByteBank — Reflection com C#

Projeto de estudo desenvolvido no curso **C# Reflection: manipule dinamicamente tipos e assemblies**, da **Alura**. Explora a inspeção de tipos em tempo de execução, atributos personalizados e o carregamento dinâmico de plugins para processar boletos e gerar relatórios.

## Conteúdo

- Leitura de boletos a partir de um arquivo CSV;
- Uso de Reflection para inspecionar propriedades e mapear dados;
- Agrupamento e totalização de boletos por cedente;
- Interface genérica `IRelatorio<T>` para padronizar relatórios;
- Atributos personalizados para nomes de colunas;
- Carregamento de assemblies e execução dinâmica de plugins;
- Geração de relatórios em formatos distintos, incluindo CSV e XML.

## Tecnologias

- C#
- .NET 10
- System.Reflection
- LINQ
- CSV e XML
- Programação orientada a objetos

## Estrutura do projeto

```text
bytebank-reflection-Csharp/
├── ByteBank.sln
├── ByteBank.ConsoleApp/
│   ├── Program.cs
│   └── Boletos.csv
├── ByteBank.Common/
│   ├── Boleto.cs
│   ├── BoletosPorCedente.cs
│   ├── LeitorDeBoleto.cs
│   ├── IRelatorio.cs
│   ├── NomeColunaAttribute.cs
│   └── RelatorioDeBoleto.cs
├── ConsultoriaABC.Plugins/
│   └── RelatorioImpressao.cs
└── ConsultoriaXYZ.Plugins/
    └── RelatorioXML.cs
```

## Como executar

### Pré-requisitos

Instale o **SDK do .NET 10**. A versão enviada foi preparada para Windows e usa o diretório fixo `C:\Plugins` para carregar plugins.

```powershell
git clone https://github.com/elitohn/bytebank-reflection-Csharp.git
cd bytebank-reflection-Csharp
New-Item -ItemType Directory -Force C:\Plugins
dotnet restore ByteBank.sln
dotnet build ByteBank.sln
dotnet run --project ByteBank.ConsoleApp
```

> **Observação:** os projetos de plugins incluem etapas de compilação para copiar as DLLs ao diretório `C:\Plugins`. Caso a execução falhe, confira os caminhos locais, o arquivo `Boletos.csv` e as DLLs geradas.

## Objetivo

Praticar **Reflection**, **assemblies**, **atributos** e **extensibilidade por plugins** em C#, compreendendo como uma aplicação pode descobrir e executar implementações sem depender diretamente delas em tempo de compilação.

Projeto baseado no curso [C# Reflection: manipule dinamicamente tipos e assemblies](https://cursos.alura.com.br/course/csharp-reflection-manipule-dinamicamente-tipos-assemblies), da Alura.

Desenvolvido por **Wellyton Huan**.
