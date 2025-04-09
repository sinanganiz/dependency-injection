# Dependency Injection Examples in .NET

This repository demonstrates **Dependency Injection (DI)** in .NET using two separate projects:

- `ConsoleAppDI/`: A lightweight console application that manually sets up DI.
- `WebApiDI/`: An ASP.NET Core Web API project that leverages built-in DI features.

The goal is to showcase how DI can help build loosely coupled, maintainable, and testable applications in both minimal and full-featured .NET environments.

📝 These examples are also explained in detail in the blog post:  
👉 <a href="https://sinanganiz.com/posts/dependency-injection" target="_blank">Read the blog post here!</a>

## 🗂️ Project Structure

    .
    ├── ConsoleAppDI/
    ├── WebApiDI/
    ├── dependency-injection.sln
    └── README.md

## 💡 About Dependency Injection

Dependency Injection is a software design pattern that allows a class to receive its dependencies from an external source rather than creating them itself. This promotes:

- Separation of concerns
- Code reuse and testability
- Flexibility in switching implementations

Both projects here use the same abstraction: `IMessageSender`, with two implementations:

- `EmailSender`
- `SmsSender`


## 🚀 How to Run

You can run any example individually.

### 📌 Prerequisites

.NET 9 SDK

### ▶️ Run ConsoleAppDI

```bash
cd ConsoleAppDI
dotnet run
```

You will see output like:

```bash
Email sent: Hello Dependency Injection!
```

To switch to ``SmsSender``, edit the DI registration line in ``Program.cs``:

```csharp
services.AddTransient<IMessageSender, SmsSender>();
```

### ▶️ Run WebApiDI

```bash
cd WebApiDI
dotnet run
```

Once the API is running, you can send a POST request to:

```bash
POST https://localhost:5001/api/notification
Content-Type: application/json

"Hello from Web API!"
```

Expected console output:

```bash
Email sent: Hello from Web API!
```

To use SmsSender, change the registration in Program.cs:

```csharp
builder.Services.AddTransient<IMessageSender, SmsSender>();
```

## 📂 Core Concepts Demonstrated
Constructor Injection

Interface-based abstraction (IMessageSender)

Manual vs Built-in DI container

Loose coupling

