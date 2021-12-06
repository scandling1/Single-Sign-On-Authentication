FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/SsoProject.STS.Identity/SsoProject.STS.Identity.csproj", "src/SsoProject.STS.Identity/"]
COPY ["src/SsoProject.Admin.EntityFramework.Shared/SsoProject.Admin.EntityFramework.Shared.csproj", "src/SsoProject.Admin.EntityFramework.Shared/"]
COPY ["src/SsoProject.Shared/SsoProject.Shared.csproj", "src/SsoProject.Shared/"]
RUN dotnet restore "src/SsoProject.STS.Identity/SsoProject.STS.Identity.csproj"
COPY . .
WORKDIR "/src/src/SsoProject.STS.Identity"
RUN dotnet build "SsoProject.STS.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SsoProject.STS.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "SsoProject.STS.Identity.dll"]