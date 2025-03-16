# 1️⃣ Fase de Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia apenas os arquivos do projeto (.csproj) antes do restore
COPY ["ApiGateway/ApiGateway.csproj", "ApiGateway/"]

# Confirma que o arquivo foi copiado corretamente
RUN dir /src/ApiGateway

# Restaura as dependências
WORKDIR /src/ApiGateway
RUN dotnet restore

# Copia o restante dos arquivos
COPY ApiGateway/. .
WORKDIR "/src/ApiGateway"

# Compila e publica a aplicação
RUN dotnet publish -c Release -o /app/publish

# 2️⃣ Fase de Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Expõe a porta correta do ApiGateway
EXPOSE 5006

# Comando de entrada
ENTRYPOINT ["dotnet", "ApiGateway.dll"]
