https://docs.microsoft.com/en-us/visualstudio/ide/how-to-create-multi-project-templates

Web.Api project fix
https://stackoverflow.com/questions/44164508/missing-folders-in-custom-visual-studio-project-template

https://docs.microsoft.com/en-us/visualstudio/ide/how-to-substitute-parameters-in-a-template

Project frameworks used in this template:
- .Net Standard 2 (Class libraries)
- .NET Core 2 (Web.Api)
- XUnit (UnitTests)

Nuget references are kept intact and downloaded to develoeprs pc when solution is loaded

NB: .NET 4.6 projects have issue with nuget referneces when solution is loaded so using XUnit types instead.