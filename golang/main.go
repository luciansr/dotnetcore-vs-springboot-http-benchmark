package main

import (
	"strconv"

	"github.com/kataras/iris"
	"github.com/kataras/iris/context"
)

func main() {
	app := iris.New()
	app.Get("/api/benchmark/{id}", func(ctx context.Context) {
		id, _ := ctx.Params().GetInt("id")
		ctx.WriteString("value: " + strconv.Itoa(id))
	})
	app.Run(iris.Addr(":8181"))
}
