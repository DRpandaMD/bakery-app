FROM mcr.microsoft.com/dotnet/core/sdk:3.0 as build-env
WORKDIR /Bakery

COPY /Bakery/*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY ./Bakery ./
RUN dotnet publish -c D -o out

#now from the runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /Bakery
COPY --from=build-env /Bakery/out .
ENTRYPOINT ["dotnet", "Bakery.dll"]