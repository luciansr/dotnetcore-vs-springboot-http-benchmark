#How to run 
```
dotnet publish
dotnet ./bin/Release/netcoreapp2.1/publish/Benchmark.dll --server.urls=http://localhost:5000
bombardier -c 125 -n 1000000 http://localhost:5000/api/values
```