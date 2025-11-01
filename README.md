# Line Processing — Приклад SOLID (Single Responsibility Principle)

Цей проєкт демонструє **принцип єдиного обов'язку (SRP)** із SOLID у мові C#.

## Суть принципу SRP

> **Клас повинен мати тільки одну причину для зміни.**

Тобто кожен клас відповідає **за одну чітку задачу**.  
Якщо клас має більше ніж одну відповідальність — це ускладнює підтримку та модифікацію коду.

---

## Структура проєкту

У прикладі є два класи з різними зонами відповідальності:

| Клас | Відповідальність | Пояснення |
|------|-----------------|-----------|
| `Line` | Зберігання та доступ до текстової строки | Керує даними |
| `LineTransformer` | Операції перетворення строки | Виконує логіку обробки |

---

## Код:

```csharp
internal class Line
{
    private string _line;

    public string Value
    {
        get => _line;
        set => _line = value;
    }

    public int Length => _line.Length;
}

internal static class LineTransformer
{
    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
## Line - віповідає лише за зберігання рядка || LineTransformer - відвовідає лише за зміну рядка

## Приклад використання:

Line line = new Line();
line.Value = "Single responsibility principle";

Console.WriteLine(line.Value);
Console.WriteLine(LineTransformer.Reverse(line.Value));


