$path = Get-Location
dotnet test $path"\Application.UnitTests.csproj"  /p:CollectCoverage=true /p:Threshold=80
pause