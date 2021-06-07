# Converter

## Overview

Demo available here: https://convert-demo.azurewebsites.net/

A simple (but purposely over-engineered) temperature converter. It consists of a .NET 5 back-end and Angular client application. The units of temperature and conversions are provided by an API.

- `GET /api/UnitsOfTemperature` - get all units of temperature in the system
- `GET /api/UnitsOfTemperature/{id}` - get a single unit of temperature by id
- `GET /api/Convert` - Performs the conversion, but requires query string parameters:
  - `value` - The value to convert
  - `fromUnitId` - The Id of the unit of temperature to convert from
  - `toUnitId` - The Id of the unit of temperature to convert to

## Prerequisites

- .NET 5 SDK
- node.js

## To Run

- run `npm install` in Web\ClientApp directory
- from root directory run
  - `dotnet build Converter.sln`
  - `dotnet run --project ./Web/Web.csproj`
- Browse to https://localhost:5001/home

Alternatively, open in Visual Studio and run.

## Troubleshooting

- The console may log failures relating to Microsoft.AspNetCore.SpaServices - this is just Angular logging to the same stream and is not actually a failure.

## Extending

### Adding new temperatures

To add a new temperature, simply add a new `UnitOfTemperature` item to the `unitsOfTemperature` collection within `UnitsOfTemperatureService`. This should consist of a unique Id, a name, and functions for converting to and from Kelvin.

### Futher extension TODO list

- Moving the `unitsOfTemperature` collection into a database so that the collection can be updated in production without rebuilding/redeploying?
- Angular page and API endpoints for adding/removing units of temperature?
- Increase unit test coverage!
- Security considerations?
  - Rate limiting API requests
  - Hiding sensitive response headers (Server, X-Powered-By, etc)
- Assess accessibility
- Demo site with CI/CD pipeline via AzureDevOps
