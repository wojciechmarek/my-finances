# MyFinances

This a simple web application allowing you to see polish stock prices, details about the stock and save single stock in a favorites list.

## Purpose

MyFinances was created as a part of a project for a class at university. The main aim of the project was to implement as many Software Design Patterns as we can.

Design patterns included:

- Adapter - wraps an external fake API
- Singleton - stores user credentials globally
- Command - invokes buttons pressed in another place
- Facade - hides database services implementation
- State - changes the content of the object with details info

## Screenshots:

- Main page view:

  ![main](https://user-images.githubusercontent.com/27026036/206000364-e5636f28-1495-4a02-87e0-d162ef7b6ca0.png)

- Search page view:

  ![main](https://user-images.githubusercontent.com/27026036/206000571-9753db0e-5e69-46b6-9764-3147270fcfb0.png)

- Stock details modal:

  ![main](https://user-images.githubusercontent.com/27026036/206000672-393edee4-5247-4a82-83d9-af3589fc0c77.png)

## Used technologies
- Blazor framework ❤️ - server version
- .Net Core 3.1
- Visual Studio 2021
- C# programming language

## Blazor

It a Microsoft's modern framework to build web applications using a popular C# programming language. There are two options given to developers:
- Blazor server - a frontend app uses a real-time communication to the server to process all data on it (communication-based on SignalR library)
- Blazor WASM - a frontend app is compiled from C# to WebAssembly binary language and runs in a browser like other SPA apps: React or Angular

Nice work Micro$oft, don't mess it up! 👍

## How to run

Install .Net Core 3.1, then navigate to `/MyFinances.UI`, restore Nuget packages, compile and run it (or install a certificate if needed) using standard CLI commands. Also, you can use Visual Studio, it should tell you what you need and configure everything out-of-the-box.
