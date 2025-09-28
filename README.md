# Single-Responsibility-Principle
Цей приклад демонструє, як застосовується SRP у C#.

```
code:
```csharp
Line line = new Line();
line.Value = "Single responsibility principle";

Console.WriteLine(line.Value);
Console.WriteLine(LineTransformer.Reverse(line.Value));
