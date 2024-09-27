FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Gruppe_oppgave1/Gruppe_oppgave1.csproj", "Gruppe_oppgave1/"]
RUN dotnet restore "Gruppe_oppgave1/Gruppe_oppgave1.csproj"
COPY . .
WORKDIR "/src/Gruppe_oppgave1"
RUN dotnet build "Gruppe_oppgave1.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Gruppe_oppgave1.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gruppe_oppgave1.dll"]
