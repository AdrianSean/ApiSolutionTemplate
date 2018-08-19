$path = Get-Location
dotnet test $path"\Web.Api.UnitTests.csproj"  /p:CollectCoverage=true
pause