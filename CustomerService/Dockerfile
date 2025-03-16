# Fase de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["CustomerService/CustomerService.csproj", "CustomerService/"]
COPY ["AkadInsuranceHub.Shared/AkadInsuranceHub.Shared.csproj", "AkadInsuranceHub.Shared/"]

RUN dotnet restore "CustomerService/CustomerService.csproj"

COPY CustomerService/. CustomerService/
COPY AkadInsuranceHub.Shared/. AkadInsuranceHub.Shared/
WORKDIR "/src/CustomerService"
RUN dotnet publish -c Release -o /app/publish

# Fase de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 5048
ENTRYPOINT ["dotnet", "CustomerService.dll"]
