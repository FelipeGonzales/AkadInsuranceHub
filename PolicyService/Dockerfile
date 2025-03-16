# Fase de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["PolicyService/PolicyService.csproj", "PolicyService/"]
COPY ["AkadInsuranceHub.Shared/AkadInsuranceHub.Shared.csproj", "AkadInsuranceHub.Shared/"]

RUN dotnet restore "PolicyService/PolicyService.csproj"

COPY PolicyService/. PolicyService/
COPY AkadInsuranceHub.Shared/. AkadInsuranceHub.Shared/
WORKDIR "/src/PolicyService"
RUN dotnet publish -c Release -o /app/publish

# Fase de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 5058
ENTRYPOINT ["dotnet", "PolicyService.dll"]
