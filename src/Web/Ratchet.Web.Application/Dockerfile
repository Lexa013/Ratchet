FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Web/Ratchet.Web.Application/Ratchet.Web.Application.csproj", "Ratchet.Web.Application/"]
RUN dotnet restore "src/Web/Ratchet.Web.Application/Ratchet.Web.Application.csproj"
COPY . .
WORKDIR "/src/Ratchet.Web.Application"
RUN dotnet build "Ratchet.Web.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ratchet.Web.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ratchet.Web.Application.dll"]
