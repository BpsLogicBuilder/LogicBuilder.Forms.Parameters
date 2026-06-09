# LogicBuilder.Forms.Parameters

[![Build Status](https://github.com/BpsLogicBuilder/LogicBuilder.Forms.Parameters/actions/workflows/ci.yml/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.Forms.Parameters/actions/workflows/ci.yml)
[![CodeQL](https://github.com/BpsLogicBuilder/LogicBuilder.Forms.Parameters/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.Forms.Parameters/actions/workflows/github-code-scanning/codeql)
[![codecov](https://codecov.io/gh/BpsLogicBuilder/LogicBuilder.Forms.Parameters/graph/badge.svg?token=U8W913QAKI)](https://codecov.io/gh/BpsLogicBuilder/LogicBuilder.Forms.Parameters)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=BpsLogicBuilder_LogicBuilder.Forms.Parameters&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=BpsLogicBuilder_LogicBuilder.Forms.Parameters)
[![NuGet](https://img.shields.io/nuget/v/LogicBuilder.Forms.Parameters.svg)](https://www.nuget.org/packages/LogicBuilder.Forms.Parameters)

## Overview

This library provides parameter classes that serve as a contract between the [LogicBuilder application](https://github.com/BpsLogicBuilder/LogicBuilder) and .NET applications. These parameter classes enable users to configure data structures in the Logic Builder Client's visual designer, which are then serialized and used to generate LINQ expressions at runtime in .NET applications.

## Purpose

The library bridges the gap between visual design-time configuration and runtime code execution by:
1. **Collecting structured data** in the Logic Builder Client using .NET Forms-based editors
2. **Serializing configuration** for transfer between the designer and runtime applications
3. **Enabling dynamic LINQ expression generation** at runtime based on design-time configuration

## Key Components

### ConnectorParameters

The `ConnectorParameters` class holds information about connector shapes on flow diagrams and their corresponding UI implementations.

#### Properties

- **`Id`** (`int`): The unique identifier for the connector.
- **`ShortString`** (`string`): A resource file key used as a reference for the `LongString` property. This enables localization and resource management.
- **`LongString`** (`string`): The display text or full description associated with the connector/button.
- **`ConnectorData`** (`object`): Additional metadata about the button's appearance and behavior, provided by developers at design time. This flexible property allows for custom data structures specific to your application's needs.

### Expressions Namespace

The `Expressions` folder contains parameter classes that represent LINQ expression components. These classes implement the `IExpressionParameter` interface and are used to build expression trees at runtime.

#### Core Expression Classes

- **`BinaryOperatorParameters`**: Abstract base class for binary operations with left and right operands
  - `EqualsBinaryOperatorParameters`: Equality comparison (==)
  - `NotEqualsBinaryOperatorParameters`: Inequality comparison (!=)
  - `GreaterThanBinaryOperatorParameters`: Greater than comparison (>)
  - `GreaterThanOrEqualsBinaryOperatorParameters`: Greater than or equal comparison (>=)
  - `LessThanBinaryOperatorParameters`: Less than comparison (<)
  - `LessThanOrEqualsBinaryOperatorParameters`: Less than or equal comparison (<=)
  - `AndBinaryOperatorParameters`: Logical AND (&&)
  - `OrBinaryOperatorParameters`: Logical OR (||)

#### Unary and Value Operators

- **`NotOperatorParameters`**: Logical NOT operation (!)
- **`ConstantOperatorParameters`**: Represents constant values with optional type information
- **`CollectionConstantOperatorParameters`**: Represents collections of constant values with element type
- **`ParameterOperatorParameters`**: Represents lambda expression parameters

#### Member Access and Type Conversion

- **`MemberSelectorOperatorParameters`**: Accesses properties or fields from a source operand (e.g., `entity.Property`)
- **`ConvertOperatorParameters`**: Type conversion operations

#### Collection Operations

- **`InOperatorParameters`**: Checks if an item exists in a collection
- **`ContainsOperatorParameters`**: String or collection contains operation
- **`AsEnumerableOperatorParameters`**: Converts to IEnumerable
- **`AsQueryableOperatorParameters`**: Converts to IQueryable

#### Lambda Expressions

- **`FilterLambdaOperatorParameters`**: Represents filter predicates (e.g., `x => x.Age > 18`)
  - Properties: `FilterBody`, `SourceElementType`, `ParameterName`
- **`SelectorLambdaOperatorParameters`**: Represents projection/selector expressions (e.g., `x => x.Name`)
  - Properties: `Selector`, `SourceElementType`, `BodyType`, `ParameterName`

### Expansions Namespace

The `Expansions` folder contains parameter classes for OData-style query operations, particularly for expanding and projecting related entities.

#### Select/Expand Operations

- **`SelectExpandItemParameters`**: Configures navigation property expansions with optional filtering, sorting, and field selection
  - `MemberName`: Navigation property name to expand
  - `Filter`: Optional filter for collection navigation properties
  - `QueryFunction`: Optional sorting, skip, and take operations
  - `Selects`: List of fields to select (projection)
  - `ExpandedItems`: Nested expansions for related entities

- **`SelectExpandItemFilterParameters`**: Wraps filter lambda expressions for navigation property filtering

- **`SelectExpandItemQueryFunctionParameters`**: Configures query operations on expanded collections

#### Sorting and Paging

- **`SortCollectionParameters`**: Defines sorting, skip, and take operations for collections
  - `SortDescriptions`: List of sort criteria
  - `Skip`: Number of items to skip (pagination)
  - `Take`: Maximum number of items to return (page size)

- **`SortDescriptionParameters`**: Individual sort criteria
  - `PropertyName`: Property to sort by
  - `SortDirection`: Ascending or descending order

## Usage Workflow

1. **Design Time**: Users configure queries, filters, and data operations in the Logic Builder Client using visual forms populated by these parameter classes
2. **Serialization**: The configured parameters are serialized (typically to JSON or XML)
3. **Runtime**: .NET applications deserialize the parameters and use them to construct LINQ expression trees dynamically
4. **Execution**: The generated expressions are executed against data sources (Entity Framework, LINQ to Objects, etc.)

## Example Scenario

A user might configure a query in Logic Builder to:
- Filter products where `Price > 100`
- Sort by `Name` ascending
- Select only `Id`, `Name`, and `Price` fields
- Expand the `Category` navigation property

This configuration would be captured using classes like `FilterLambdaOperatorParameters`, `SortCollectionParameters`, and `SelectExpandItemParameters`, then used at runtime to generate the equivalent LINQ expression.

## Installation
`dotnet add package LogicBuilder.Forms.Parameters`