package main

import (
	"C"
	"fmt"

	"example.com/greetings"
)

func main() {
	fmt.Println(greetings.Hello("MainFunc"))
	//fmt.Println("Type you name and press Enter:")
	//var x = fmt.Readln()
	//fmt.Println("Hello, " + x)
}

//export helloGo
func helloGo(name string) string {
	return greetings.Hello(name)
}
