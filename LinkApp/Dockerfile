FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["LinkApp/LinkApp.csproj", "LinkApp/"]
RUN dotnet restore "LinkApp/LinkApp.csproj"
COPY . .
WORKDIR "/src/LinkApp"
RUN dotnet build "LinkApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LinkApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LinkApp.dll"]
