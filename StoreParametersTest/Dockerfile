FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
ENV ASPNETCORE_URLS="http://*:5000"
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["StoreParametersTest.csproj", "StoreParametersTest/"]
COPY . "StoreParametersTest/"

RUN sudo security add-trusted-cert -d -r trustRoot -k /Library/Keychains/System.keychain https.crt

WORKDIR "/src/StoreParametersTest"
RUN dotnet build "StoreParametersTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StoreParametersTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StoreParametersTest.dll"]