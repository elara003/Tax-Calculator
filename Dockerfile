FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Tax calculator.csproj", "./"]
RUN dotnet restore "./Tax calculator.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Tax calculator.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Tax calculator.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Tax calculator.dll"]
