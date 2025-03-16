# 1️⃣ Fase de Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia apenas os arquivos do projeto antes do restore
COPY ["CustomerService/CustomerService.csproj", "CustomerService/"]
COPY ["AkadInsuranceHub.Shared/AkadInsuranceHub.Shared.csproj", "AkadInsuranceHub.Shared/"]

# Restaura as dependências
WORKDIR /src/CustomerService
RUN dotnet restore

# Copia o restante dos arquivos
COPY . .

# Compila e publica a aplicação
RUN dotnet publish -c Release -o /app/publish

# 2️⃣ Fase de Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Expõe a porta correta do CustomerService
EXPOSE 5048

# Comando de entrada
ENTRYPOINT ["dotnet", "CustomerService.dll"]
