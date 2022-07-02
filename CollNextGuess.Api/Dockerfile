#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CollNextGuess.Api/CollNextGuess.Api.csproj", "CollNextGuess.Api/"]
COPY ["CollNextGuess.Infrastructure/CollNextGuess.Infrastructure.csproj", "CollNextGuess.Infrastructure/"]
COPY ["CollNextGuess.Core/CollNextGuess.Core.csproj", "CollNextGuess.Core/"]
RUN dotnet restore "CollNextGuess.Api/CollNextGuess.Api.csproj"
COPY . .
WORKDIR "/src/CollNextGuess.Api"
RUN dotnet build "CollNextGuess.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CollNextGuess.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CollNextGuess.Api.dll"]