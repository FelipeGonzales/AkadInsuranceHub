# Fase de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["PaymentService/PaymentService.csproj", "PaymentService/"]
COPY ["AkadInsuranceHub.Shared/AkadInsuranceHub.Shared.csproj", "AkadInsuranceHub.Shared/"]

RUN dotnet restore "PaymentService/PaymentService.csproj"

COPY PaymentService/. PaymentService/
COPY AkadInsuranceHub.Shared/. AkadInsuranceHub.Shared/
WORKDIR "/src/PaymentService"
RUN dotnet publish -c Release -o /app/publish

# Fase de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 5247
ENTRYPOINT ["dotnet", "PaymentService.dll"]
