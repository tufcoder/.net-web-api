# Create a web API project

https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/3-exercise-create-web-api

This project uses the `.NET 6.0 SDK`.

```powershell
dotnet --list-sdks
dotnet new webapi -f net6.0
```

```bash
-| Controllers
-| obj
-| Properties
-| appsettings.Development.json
-| appsettings.json
-| ContosoPizza.csproj
-| Program.cs
-| WeatherForecast.cs
```

## HTTP Status Codes

* GET
  * 200: OK
  * 404: Not Found
* POST
  * 201: Created At Action
  * 400: Bad Request
* PUT / PATCH
  * 204: No Content
  * 400: Bad Request
* DELETE
  * 204: No Content
  * 404: Not Found
