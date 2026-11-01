# Функция B: остаток попыток (feature/b)

Для каждого переданного задания остаток равен 3 - Attempts, но не меньше 0.
Остатки складываются, сводка выводится строкой `Slots: {сумма}`.
Формат строки задания: `{Name}; attempts={Attempts}`. Отбора в ветке нет,
поэтому выводятся все исходные задания.

| Запуск | Вход | Ожидается | Получено |
|---|---|---|---|
| `dotnet run` | jobA/0, jobB/1, jobC/3, jobD/4 | 4 строки и Slots: 5 | jobA; attempts=0, jobB; attempts=1, jobC; attempts=3, jobD; attempts=4, Slots: 5 |
| `dotnet run -- over` | over/4 | over; attempts=4 и Slots: 0 (не -1) | over; attempts=4, Slots: 0 |
| `dotnet run -- empty` | пустой массив | только Slots: 0 | Slots: 0 |
