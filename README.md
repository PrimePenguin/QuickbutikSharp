# QuickbutikSharp: A .NET library for Quickbutik.

Quickbutik is a .NET library that enables you to authenticate and make API calls to Quickbutik. It's great for 
building custom Quickbutik Apps using C# and .NET. You can quickly and easily get up and running with Quickbutik
using this library.

# Installation

Quickbutik is [available on NuGet](https://www.nuget.org/packages/Quickbutik/). Use the package manager
console in Visual Studio to install it:

```
Install-Package Quickbutik
```

If you're using .NET Core, you can use the `dotnet` command from your favorite shell:

```
dotnet add package Quickbutik
```

# Using Quickbutik

**Note**: All instances of `apiKey` in the examples below **do not refer to your Quickbutik API key**.
An access token is the token returned after authenticating and authorizing a Quickbutik app installation with a
real Quickbutik store.


```cs
var service = new ProductService(apiKey);
```

# APIS Implemented
- Order
- Product
