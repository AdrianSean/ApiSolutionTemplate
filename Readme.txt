*************
Documentation
*************
Creating a solution template:
https://docs.microsoft.com/en-us/visualstudio/ide/how-to-create-multi-project-templates

Item template -substiting parameter names
https://docs.microsoft.com/en-us/visualstudio/ide/how-to-substitute-parameters-in-a-template

Web.Api project fix (ensure all files get listed)
https://stackoverflow.com/questions/44164508/missing-folders-in-custom-visual-studio-project-template

*********
Breakdown
*********
Project frameworks used in this template:
- .Net Standard 2 (Class libraries)
- .NET Core 2 (Web.Api)
- XUnit (UnitTests)

Nuget references are kept intact and downloaded to develoeprs pc when solution is loaded

NB: .NET 4.6 projects have issue with nuget referneces when solution is loaded so using XUnit types instead.

********************************
EXPORT LOCATION FOR THE SOLUTION 
********************************
VS 2017: C:\Users\YourName\OneDrive\Documents\Visual Studio 2017\Templates\ProjectTemplates