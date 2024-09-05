FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /build
COPY . .
RUN dotnet publish GatewayA.csproj -c Release -o dist

FROM mcr.microsoft.com/dotnet/aspnet:8.0 as app
WORKDIR /app
COPY --from=build /build/dist .

ENTRYPOINT [ "dotnet", "GatewayA.dll" ]