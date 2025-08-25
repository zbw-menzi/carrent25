FROM mcr.microsoft.com/dotnet/aspnet:9.0-noble-chiseled-extra
WORKDIR /app
# Usually, you would do a dotnet publish,
# and use the dll's from that location
COPY ./bin/Debug/net9.0/ . 
ENTRYPOINT ["dotnet", "CarRent.Api.dll"]
