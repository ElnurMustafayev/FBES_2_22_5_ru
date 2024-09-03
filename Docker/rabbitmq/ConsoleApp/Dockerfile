FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /build
COPY . .
RUN dotnet publish -c Release -o dist

FROM mcr.microsoft.com/dotnet/runtime:8.0 as app
WORKDIR /app
COPY --from=build /build/dist .

ENTRYPOINT [ "dotnet", "ConsoleApp.dll" ]