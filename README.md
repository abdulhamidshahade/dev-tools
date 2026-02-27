# DevTools

A modern full-stack web application built with .NET 9 and React.

## Tech Stack

### Backend (DevTools.API)
- **.NET 9.0** - Web API
- **ASP.NET Core** - Framework
- **OpenAPI** - API documentation

### Frontend (DevTools.Web)
- **React 19** - UI library
- **TypeScript** - Type safety
- **Vite** - Build tool and dev server
- **ESLint** - Code linting

## Project Structure

```
DevTools/
├── DevTools.API/          # .NET 9 Web API backend
│   ├── Controllers/       # API endpoints
│   ├── Properties/        # Launch settings
│   └── appsettings.json   # Configuration
├── DevTools.Web/          # React frontend
│   ├── src/               # Source files
│   ├── public/            # Static assets
│   └── index.html         # Entry point
└── .github/               # GitHub workflows
```

## Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (LTS version recommended)
