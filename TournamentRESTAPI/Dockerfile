FROM mcr.microsoft.com/dotnet/aspnet:3.1-alpine AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["TournamentRESTAPI/TournamentRESTAPI.csproj", "TournamentRESTAPI/"]
RUN dotnet restore "TournamentRESTAPI/TournamentRESTAPI.csproj"
COPY . .
WORKDIR "/src/TournamentRESTAPI"
RUN dotnet build "TournamentRESTAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TournamentRESTAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TournamentRESTAPI.dll"]