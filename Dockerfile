FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build

# build application 
WORKDIR /src
COPY . .

WORKDIR /src/FsDockerTest.Tests
RUN dotnet restore
RUN dotnet test


WORKDIR /src/FsDockerTest
RUN dotnet restore
RUN dotnet publish -c release -o /app --no-self-contained --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine

WORKDIR /app
COPY --from=build /app .

ENTRYPOINT ["./FsDockerTest"]
