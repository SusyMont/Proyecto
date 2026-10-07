# Food API

A small REST API for a food business, built as an educational project with ASP.NET Core and PostgreSQL.

## Current stage

The project currently contains the initial ASP.NET Core Web API skeleton:

- Controllers are registered in `Program.cs`.
- OpenAPI is enabled in the development environment.
- The template `WeatherForecastController` demonstrates a first HTTP endpoint.

The application does not use a database or application services yet. Those pieces will be added one small step at a time.

## Run locally

```bash
dotnet run --urls http://localhost:5080
```

Then request the sample endpoint:

```bash
curl http://localhost:5080/WeatherForecast
```

## Learning path

1. Understand Controllers and HTTP.
2. Add PostgreSQL and Entity Framework Core.
3. Build Categories and Products.
4. Introduce DTOs and Services.
5. Add Orders and validation.
6. Deploy the API manually to a DigitalOcean Droplet.
