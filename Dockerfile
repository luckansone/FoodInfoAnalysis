FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["FoodHazardAnalysis/FoodHazardAnalysis.csproj", "FoodHazardAnalysis/"]
RUN dotnet restore "FoodHazardAnalysis/FoodHazardAnalysis.csproj"
COPY . .
WORKDIR "/src/FoodHazardAnalysis"
RUN dotnet build "FoodHazardAnalysis.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "FoodHazardAnalysis.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FoodHazardAnalysis.dll"]
