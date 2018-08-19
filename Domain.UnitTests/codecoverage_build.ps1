$path = Get-Location
dotnet test $path"\Domain.UnitTests.csproj"  /p:CollectCoverage=true
pause