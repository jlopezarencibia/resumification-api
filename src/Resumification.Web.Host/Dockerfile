FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Resumification.Web.Host/Resumification.Web.Host.csproj", "src/Resumification.Web.Host/"]
COPY ["src/Resumification.Web.Core/Resumification.Web.Core.csproj", "src/Resumification.Web.Core/"]
COPY ["src/Resumification.Application/Resumification.Application.csproj", "src/Resumification.Application/"]
COPY ["src/Resumification.Core/Resumification.Core.csproj", "src/Resumification.Core/"]
COPY ["src/Resumification.EntityFrameworkCore/Resumification.EntityFrameworkCore.csproj", "src/Resumification.EntityFrameworkCore/"]
WORKDIR "/src/src/Resumification.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Resumification.Web.Host", "src/Resumification.Web.Host"]
COPY ["src/Resumification.Web.Core", "src/Resumification.Web.Core"]
COPY ["src/Resumification.Application", "src/Resumification.Application"]
COPY ["src/Resumification.Core", "src/Resumification.Core"]
COPY ["src/Resumification.EntityFrameworkCore", "src/Resumification.EntityFrameworkCore"]
WORKDIR "/src/src/Resumification.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Resumification.Web.Host.dll"]
