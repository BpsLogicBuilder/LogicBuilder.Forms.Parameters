# LogicBuilder.Forms.Parameters

[![Build Status](https://github.com/BpsLogicBuilder/LogicBuilder.Forms.Parameters/actions/workflows/ci.yml/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.Forms.Parameters/actions/workflows/ci.yml)
[![CodeQL](https://github.com/BpsLogicBuilder/LogicBuilder.Forms.Parameters/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.Forms.Parameters/actions/workflows/github-code-scanning/codeql)
[![codecov](https://codecov.io/gh/BpsLogicBuilder/LogicBuilder.Forms.Parameters/graph/badge.svg?token=U8W913QAKI)](https://codecov.io/gh/BpsLogicBuilder/LogicBuilder.Forms.Parameters)
[![NuGet](https://img.shields.io/nuget/v/LogicBuilder.Forms.Parameters.svg)](https://www.nuget.org/packages/LogicBuilder.Forms.Parameters)

A library that defines the `ConnectorParameters` class, which serves as a contract between [LogicBuilder application](https://github.com/BpsLogicBuilder/LogicBuilder) and .NET Forms applications.

## Purpose

This library provides a standardized way to transfer information about Connector Shapes from flow diagrams created in Logic Builder Client to .NET Forms applications where they are typically implemented as UI buttons.

## ConnectorParameters Class

The `ConnectorParameters` class holds information about a connector shape on a flow diagram along with additional metadata about the UI button it represents and its behaviors.

### Properties

- **`Id`** (`int`): The unique identifier for the connector.
- **`ShortString`** (`string`): A resource file key used as a reference for the `LongString` property. This enables localization and resource management.
- **`LongString`** (`string`): The display text or full description associated with the connector/button.
- **`ConnectorData`** (`object`): Additional metadata about the button's appearance and behavior, provided by developers at design time. This flexible property allows for custom data structures specific to your application's needs.

## Usage

This library acts as a contract between:
1. **The LogicBuilder Application** - where users configure connectors with data at design time
2. **.NET Forms Applications** - where buttons representing connectors are implemented at runtime

## Installation
`dotnet add package LogicBuilder.Forms.Parameters`