# Bind() for C#
A one-class auto-generated library for C# that introduces function binding for C#. Basically just a big file with generic closures.

## Here's a few examples of what it does.

Binding a method with a single parameter and return value.
```cs
var toUpperBinding = BindFunc(ToUpper, "Hello, world!");
Console.WriteLine(toUpperBinding()); // "HELLO, WORLD!"
```

The compiler needs some help with unsupplied arguments because it won't be able to indentify their types.
```cs
var bindAdd = BindFunc<int, int, int>(Add, 4);
Console.WriteLine(bindAdd(4)); // 8
```

Unlike default C#, you can now use var with lambda expressions!
```cs
var multiplyLambda = BindFunc((int a, int b) => a * b);
Console.WriteLine(multiplyLambda(2, 8)); // == 16            
```

Completely implicit binding (as long as you supply all arguments, as mentioned before).
```cs
var connectLambda = BindAction((a, p) => Console.WriteLine("Connecting to {0}:{1}...", a, p), "127.0.0.1", 7777);
connectLambda(); // Connecting to 127.0.0.1:7777...
```
