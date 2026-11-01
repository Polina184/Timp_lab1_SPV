# GitLab — повторные попытки выполнения заданий

Студентка: Сорокина П.В.  
Вариант 12 «Повторные попытки выполнения заданий»

Диспетчер формирует список заданий, для которых ещё разрешены попытки,
и считает общий остаток попыток. Лимит — три попытки на задание.
Программа не запускает задания и не увеличивает счётчик.

## Функции

- **A (ветка feature/a)** — `Selection.Apply` оставляет задания с
  Attempts < 3, формат строки `RETRY: {Name}`.
- **B (ветка feature/b)** — `Summary.Build` считает для каждого задания
  остаток `max(0, 3 - Attempts)` и выводит сумму `Slots: {сумма}`,
  формат строки `{Name}; attempts={Attempts}`.

В main сводка считается по заданиям, которые оставила функция A.
Задания с исчерпанным лимитом дают остаток 0, поэтому для основного
набора Slots: 5 и в ветке B, и в main.

## Конфликт

Обе ветки заменили строку `return item.Name;` в `Formatter.cs`.
При слиянии feature/b в main возник конфликт. Он разрешён одной строкой:

```csharp
return "RETRY: " + item.Name + "; attempts=" + item.Attempts;
```

## Запуск и проверки (main)

| Команда | Вход | Результат |
|---|---|---|
| `dotnet run` | jobA/0, jobB/1, jobC/3, jobD/4 | RETRY: jobA; attempts=0, RETRY: jobB; attempts=1, Slots: 5 |
| `dotnet run -- empty` | пустой массив | Slots: 0 |
| `dotnet run -- edge` | a/2, b/3 | RETRY: a; attempts=2, Slots: 1 |
| `dotnet run -- over` | over/4 | Slots: 0 |
| `dotnet run -- own` | build/1, deploy/2, test/5, lint/0 | RETRY: build; attempts=1, RETRY: deploy; attempts=2, RETRY: lint; attempts=0, Slots: 6 |
