# Функция A: задания с оставшимися попытками (feature/a)

Отбираются задания с Attempts < 3. При значении 3 лимит исчерпан, такие
задания и задания с большим числом попыток не выводятся. Порядок и число
попыток не меняются. Формат строки: `RETRY: {Name}`.

| Запуск | Вход | Ожидается | Получено |
|---|---|---|---|
| `dotnet run` | jobA/0, jobB/1, jobC/3, jobD/4 | RETRY: jobA, RETRY: jobB | RETRY: jobA, RETRY: jobB |
| `dotnet run -- edge` | a/2, b/3 | RETRY: a | RETRY: a |
| `dotnet run -- over` | over/4 | 0 строк | 0 строк |
| `dotnet run -- empty` | пустой массив | 0 строк | 0 строк |
