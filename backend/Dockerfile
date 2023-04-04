FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT Development
EXPOSE 7000:80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY ["/backend/backend.csproj", "/app"]
RUN dotnet restore "/app/backend.csproj"
COPY . .
WORKDIR "/app"
RUN dotnet build "backend/backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "backend/backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "backend.dll"]