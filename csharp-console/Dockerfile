FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["csharp-console/csharp-console.csproj", "csharp-console/"]
RUN dotnet restore "csharp-console/csharp-console.csproj"
COPY . .
WORKDIR "/src/csharp-console"
RUN dotnet build "csharp-console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "csharp-console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "csharp-console.dll"]
