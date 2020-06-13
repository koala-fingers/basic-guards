# Basic guard clauses

A collection of basic guard clauses used to validate input parameters in C#.

## Supported clauses

Here is a list of the supported clauses. More clauses will be added over time. Feel free to contribute with this repository.
**IsNullOrWhitespace** is used to validate string values against null or whitespace values.

```csharp
public SampleConstructor(string stringValue)
{
    this.StringValue = stringValue.ThrowIfNullOrWhitespace();
}
```
