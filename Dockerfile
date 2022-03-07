FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /webapp
EXPOSE 5000
COPY ./*.csproj ./
RUN dotnet restore

COPY . ./

RUN dotnet publish -o out


FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /webapp
COPY --from=build /webapp/out .
EXPOSE 44371
ENTRYPOINT ["dotnet", "epaycoTest.dll"]
