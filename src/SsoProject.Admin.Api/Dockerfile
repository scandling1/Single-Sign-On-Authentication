FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/SsoProject.Admin.Api/SsoProject.Admin.Api.csproj", "src/SsoProject.Admin.Api/"]
COPY ["src/SsoProject.Admin.EntityFramework.Shared/SsoProject.Admin.EntityFramework.Shared.csproj", "src/SsoProject.Admin.EntityFramework.Shared/"]
COPY ["src/SsoProject.Admin.EntityFramework.SqlServer/SsoProject.Admin.EntityFramework.SqlServer.csproj", "src/SsoProject.Admin.EntityFramework.SqlServer/"]
COPY ["src/SsoProject.Admin.EntityFramework.PostgreSQL/SsoProject.Admin.EntityFramework.PostgreSQL.csproj", "src/SsoProject.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/SsoProject.Shared/SsoProject.Shared.csproj", "src/SsoProject.Shared/"]
COPY ["src/SsoProject.Admin.EntityFramework.MySql/SsoProject.Admin.EntityFramework.MySql.csproj", "src/SsoProject.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/SsoProject.Admin.Api/SsoProject.Admin.Api.csproj"
COPY . .
WORKDIR "/src/src/SsoProject.Admin.Api"
RUN dotnet build "SsoProject.Admin.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SsoProject.Admin.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "SsoProject.Admin.Api.dll"]