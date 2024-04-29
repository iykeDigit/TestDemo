#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["FinalAPIDemo/FinalAPIDemo.csproj", "FinalAPIDemo/"]
COPY ["FinalAPIDemo.Core/FinalAPIDemo.Core.csproj", "FinalAPIDemo.Core/"]
COPY ["FinalAPIDemo.Data/FinalAPIDemo.Data.csproj", "FinalAPIDemo.Data/"]
COPY ["FinalAPIDemo.Model/FinalAPIDemo.Model.csproj", "FinalAPIDemo.Model/"]
RUN dotnet restore "./FinalAPIDemo/FinalAPIDemo.csproj"
COPY . .
WORKDIR "/src/FinalAPIDemo"
RUN dotnet build "./FinalAPIDemo.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./FinalAPIDemo.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinalAPIDemo.dll"]