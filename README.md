# Product Management Coursework

This repository holds a small .NET 9 solution I produced for a school assignment on clean architecture. The scope is intentionally limited and exists mainly as documentation of what I learned rather than a polished product.

## What It Does
- Keeps a simple JSON-backed catalog of products (create, list, edit, delete).
- Offers two basic front ends: a WPF desktop client and a console menu.
- Exercises dependency injection, repositories, and basic validation so I could practice the patterns discussed in class.

## Solution Layout

### `Infrastructure/`
Everything the two front ends rely on lives here: models, validation helpers, a service that wraps the repository, and a file-based repository that persists JSON in a file. It is intentionally small but tries to show a separation between domain logic (service) and persistence (repository) as we were taught in class.

### `Presentation.WPFApp/`
This project is a trimmed-down MVVM desktop client. There are only a couple of views (list, form) wired to matching view models through basic data binding. It was mainly built so I could demonstrate how the same service layer can drive a richer UI, not to showcase production-ready WPF craftsmanship.

### `Presentation.ConsoleApp/`
I also built a console menu to satisfy the "alternative UI" requirement. The program loops through simple prompts, uses dependency injection to resolve the service layer, and mirrors the CRUD operations from the WPF app so grading could happen without Windows.

### `Infrastructure.Tests/`
These xUnit tests cover the repository (file read/write, simple validation) and the service behaviors I discussed in the report. They are not exhaustive, but they helped me confirm the JSON storage pieces worked the same way across both UIs.

## Getting Started
Prerequisites are the .NET 9 SDK and (for the WPF app) a Windows environment. Visual Studio or VS Code work fine, but any editor with `dotnet` CLI support should do.

```bash
# Console UI
cd Presentation.ConsoleApp
dotnet run

# WPF UI (Windows only)
cd Presentation.WPFApp
dotnet run

# Tests
cd Infrastructure.Tests
dotnet test
```

## Why It Exists
The project checked the course requirements for demonstrating clean architecture layers, MVVM, and unit tests in C#. I am not actively developing it beyond that milestone, but I keep the repository around as a reference for similar lab work.
