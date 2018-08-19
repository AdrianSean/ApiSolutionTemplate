$path = Get-Location
dotnet test $path"\Repository.UnitTests.csproj"  /p:CollectCoverage=true
pause