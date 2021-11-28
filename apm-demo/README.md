# Building and publishing to docker-elasticsearch #
## Requirements
- .NET Core SDK 6.0 or above - https://dotnet.microsoft.com/download/dotnet/6.0 

# Building and running
1. ```dotnet build``` - Builds everything 
2. ```dotnet publish -c Release -o published``` - Publishes build release
3. ```docker-compose build apmdemo``` - build apmdemo container