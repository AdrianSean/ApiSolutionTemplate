$projectPath = Get-Location
$reportTool = "C:\users\"+$env:UserName+"\.nuget\packages\reportgenerator\3.1.2\tools\ReportGenerator.exe"

#1. Run Code Coverage
dotnet test $projectPath"\Repository.UnitTests.csproj" /p:CollectCoverage=true /p:CoverletOutputFormat=opencover

#2. Generate Report
Start-Process $reportTool "-reports:.\coverage.opencover.xml -targetdir:$projectPath\CodeCoverageReport"

pause