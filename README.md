# GoHelloWorld
This is a simple example to show how to consume a library (.dll or .dylib) generate by golang in a C# code.

Sometimes is not possible to consume resources directly in .NET like .lib files. As an alternative to consume those libs in C++ I'm using golang as wrapper and generating the libraries (.dll or dylib) using it to be consumed by .NET (or any other language).

The goal is to create cross libraries in golang that can be consumed by cross-platform application written in .NET.
