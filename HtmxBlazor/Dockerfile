FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["HtmxBlazor/HtmxBlazor.csproj", "HtmxBlazor/"]
RUN dotnet restore "HtmxBlazor/HtmxBlazor.csproj"
COPY . .
WORKDIR "/src/HtmxBlazor"
RUN dotnet build "HtmxBlazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HtmxBlazor.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HtmxBlazor.dll"]
