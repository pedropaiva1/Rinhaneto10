FROM mcr.microsoft.com/dotnet/nightly/sdk:10.0-preview AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

RUN apt-get update && apt-get install -y clang zlib1g-dev

COPY ["Rinhaneto10.csproj", "./"]
RUN dotnet restore "Rinhaneto10.csproj"

COPY . ./
RUN dotnet publish "./Rinhaneto10.csproj" -c $BUILD_CONFIGURATION -r linux-x64 -o /app/publish /p:PublishAot=true

FROM mcr.microsoft.com/dotnet/nightly/runtime-deps:10.0-preview AS final
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["./Rinhaneto10"]