# Fase de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["ApiGateway/ApiGateway.csproj", "ApiGateway/"]
RUN dotnet restore "ApiGateway/ApiGateway.csproj"

COPY ApiGateway/. ApiGateway/
WORKDIR "/src/ApiGateway"
RUN dotnet publish -c Release -o /app/publish

# Fase de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 5006
ENTRYPOINT ["dotnet", "ApiGateway.dll"]
