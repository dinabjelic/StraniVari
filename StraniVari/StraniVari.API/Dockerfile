#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base    
WORKDIR /app
EXPOSE 5001
ENV ASPNETCORE_URLS=http://+:5050

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["StraniVari.API/StraniVari.API.csproj", "StraniVari.API/"]
RUN dotnet restore "StraniVari.API/StraniVari.API.csproj"
COPY . .
WORKDIR "/src/StraniVari.API"
RUN dotnet build "StraniVari.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StraniVari.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StraniVari.API.dll"]