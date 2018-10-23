# How To Run
```
go get github.com/kataras/iris
go run main.go
bombardier -c 125 -n 1000000 http://localhost:8181/api/benchmark/3
```