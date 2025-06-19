# Order Pickup

Веб-приложение для приёма заказов на доставку.
Реализовано с использованием ASP.NET 9 (MVC), Entity Framework Core и PostgreSQL.

# Запуск проекта

## Требования

- .NET 9 SDK
- Docker + Docker Compose

### 1. Запуск PostgreSQL

В корне проекта есть docker-compose.yml.

Запусти БД командой:

```bash 
docker compose up -d
```

### 2. Настройка проекта

Файл appsettings.json уже содержит правильную строку подключения, если хотите что то изменить то нужно исправить строку:
```json
"ConnectionStrings": {
"Default": "Host=localhost;Port=PORT;Database=DB-NAME;Username=USERNAME;Password=PASSWORD"
}
```

### 3. Применение миграций

При первом запуске БД, нужно создать таблицы:
```bash
dotnet ef database update
```

### 4. Запуск приложения

```bash
dotnet run
```
Откройте в браузере http://localhost:5093 или же другой порт указанный в выводе ```dotnet run```



