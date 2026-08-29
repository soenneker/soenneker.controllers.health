[![](https://img.shields.io/nuget/v/soenneker.controllers.health.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.controllers.health/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.controllers.health/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.controllers.health/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.controllers.health.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.controllers.health/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.controllers.health/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.controllers.health/actions/workflows/codeql.yml)

# Soenneker.Controllers.Health

Provides a health check endpoint to verify if the service is online. Returns a message indicating the API status based on the environment.

## Install

```bash
dotnet add package Soenneker.Controllers.Health
```

## What you get

- `HealthController` — Provides a health check endpoint to verify if the service is online. Returns a message indicating the API status based on the environment.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `HealthController.Health(cancellationToken)` | Checks the health status of the API and returns a response indicating whether it is online. | Returns a 200 OK response with a health message if in development or local environment; otherwise, returns a 200 OK without a message. |

## Practical notes

- Cancellation stops pending work; it does not undo work that has already completed.
