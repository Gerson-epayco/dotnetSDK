FROM mcr.microsoft.com/dotnet/core/sdk AS build-env

WORKDIR /app

COPY *.csproj ./

RUN dotnet restore

COPY . ./

RUN dotnet publish -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/sdk

WORKDIR /app

#RUN apt-get update; apt-get install -y apt-transport-https && \
 #   apt-get update && apt-get install -y dotnet-sdk-6.0

COPY --from=build-env /app/out .

ENTRYPOINT dotnet run epaycoTest.dll