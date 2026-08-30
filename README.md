[![](https://img.shields.io/nuget/v/soenneker.controllers.health.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.controllers.health/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.controllers.health/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.controllers.health/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.controllers.health.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.controllers.health/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.controllers.health/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.controllers.health/actions/workflows/codeql.yml)

# Soenneker.Controllers.Health

Adds an anonymous MVC liveness endpoint at `GET /health`.

## Install

```bash
dotnet add package Soenneker.Controllers.Health
```

## Register the controller

```csharp
using Soenneker.Controllers.Health;

builder.Services
    .AddControllers()
    .AddApplicationPart(typeof(HealthController).Assembly);
```

Map controllers in the normal ASP.NET Core pipeline:

```csharp
app.MapControllers();
```

## Response

```http
GET /health
```

The endpoint always returns `200 OK` when the application can execute the controller:

- When configuration key `Environment` is `Local` or `Development`, the JSON response body is `"API is online"`.
- For every other value, including a missing value, the response has no body.

The controller declares API version `1` through ASP.NET API Versioning, but its route contains no version segment. The host's configured API-version reader determines whether callers must supply a version.

## Practical notes

- This is a liveness signal only. It does not check databases, queues, downstream APIs, disk, or application readiness.
- The endpoint is marked `AllowAnonymous` and excluded from API Explorer.
- If an orchestrator needs readiness or dependency checks, use ASP.NET Core Health Checks alongside or instead of this controller.
