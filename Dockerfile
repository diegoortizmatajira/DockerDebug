FROM microsoft/dotnet:2.0.0-runtime
WORKDIR /app
ENTRYPOINT ["dotnet", "DockerDebug.dll"]
COPY . /app
