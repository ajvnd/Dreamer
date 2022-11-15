FROM mcr.microsoft.com/dotnet/sdk:7.0

WORKDIR /src/

COPY . ./

RUN dotnet restore

RUN dotnet publish -c Release -o /publish/

WORKDIR /publish

ENTRYPOINT["dotnet","Dreamer.Presentation.Api"]