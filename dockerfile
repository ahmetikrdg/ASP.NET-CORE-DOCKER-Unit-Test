FROM mcr.microsoft.com/dotnet/sdk:3.1
WORKDIR /app
COPY ./HelloTest/*.csproj ./HelloTest/ 
COPY ./sonHelloApp/*.csproj ./SonHelloApp/ 
COPY *.sln .

RUN dotnet restore 
COPY . .
RUN dotnet test ./HelloTest/*.csproj
RUN dotnet publish sonHelloApp/*csproj -c Release -o out

WORKDIR out
ENV ASPNETCORE_URLS="http://*:4500"

EXPOSE 4500
ENTRYPOINT ["dotnet","SonHelloApp.dll"]

