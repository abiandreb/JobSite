FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["JobSite/JobSite.csproj", "JobSite/"]
RUN dotnet restore "JobSite/JobSite.csproj"
COPY . .
WORKDIR "/src/JobSite"
RUN dotnet build "JobSite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JobSite.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JobSite.dll"]
