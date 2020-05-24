---
title: "Schema basics"
---

# Flavours

With Hot Chocolate we strongly believe that no framework should impact the code style of developers, so we supply three approaches to define your schema. You're free to mix them up or use one, which suits your style best and is the best solution for a specific problem.

The code-first approaches (both Pure Code-First and Code-First) let us built GraphQL schemas with .NET types and it gives us all the goodness of strong types, static typing, and the confidence of using the C# compiler to validate our code.
There is no need to learn GraphQL's SDL (Schema Definition Language) syntax in order to specify our schema, we can do everything in our favorite .NET language.

The schema-first approach allows us to use GraphQL SDL to define a schema or to use existing schemas and implement execution logic with Hot Chocolate.

## Pure Code-First

PCF approach allows us to write clean C# code with usage of attributes.

## Code-First

## Schema-First

# Headlines

Use headlines to separate a document into several sections. First level headlines will appear in the left hand navigation. This will help the reader to quickly skip sections or jump to a particular section.

# Use Diagrams

Use [mermaid diagrams](https://mermaid-js.github.io/mermaid) to help a reader understand complex problems. Jump over to the [mermaid playground](https://mermaid-js.github.io/mermaid-live-editor) to test your diagrams.

```mermaid
graph TD
  A[Christmas] -->|Get money| B(Go shopping)
  B --> C{Let me think}
  C -->|One| D[Laptop]
  C -->|Two| E[iPhone]
  C -->|Three| F[fa:fa-car Car]
```

# Use Code Examples

A code example is another tool to help readers following the document and understanding the problem. Here is an list of code blocks that are used often with the ChilliCream GraphQL platform.

Use `sdl` to describe GraphQL schemas.

```sdl
type Author {
  name: String!
}
```

Use `graphql` to describe GraphQL operations.

```graphql
query {
  author(id: 1) {
    name
  }
}
```

Use `json` for everything JSON related for example a GraphQL result.

```json
{
  "data": {
    "author": {
      "name": "ChilliCream"
    }
  }
}
```

Use `sql` for SQL queries.

```sql
SELECT id FROM Authors WHERE id = 1
```

Use `csharp` for C# code.

```csharp
public interface Author
{
    int Id { get; }

    string Name { get; }
}
```

# Use Images

When using images make sure it's a PNG file which is at least 800 pixels wide.

# Use Tables

When using tables make sure you always use titles.

| Name        | Description        |
| ----------- | ------------------ |
| ChilliCream | A GraphQL platform |
