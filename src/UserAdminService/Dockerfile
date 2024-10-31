# Укажите базовый образ для приложения
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Сборка приложения
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Копирование и восстановление зависимостей
COPY ["src/UserAdminService/UserAdminService.csproj", "UserAdminService/"]
RUN dotnet restore "UserAdminService/UserAdminService.csproj"

# Копируем остальной код и собираем проект
COPY . .
WORKDIR "/src/UserAdminService"
RUN dotnet build "UserAdminService.csproj" -c Release -o /app/build

# Публикация приложения
FROM build AS publish
RUN dotnet publish "UserAdminService.csproj" -c Release -o /app/publish

# Финальный образ
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserAdminService.dll"]
