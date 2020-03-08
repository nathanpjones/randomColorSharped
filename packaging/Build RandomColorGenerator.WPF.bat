@echo off
echo ---------------------------------------------------------
echo Building RandomColorGenerator.WPF package...
echo ---------------------------------------------------------
if not exist "%~dp0packages" md "%~dp0packages"
dotnet pack "%~dp0..\RandomColorGenerator.WPF\RandomColorGenerator.WPF.csproj" --configuration Release -p:GenerateDocumentationFile=true --include-symbols -p:SymbolPackageFormat=snupkg --output "%~dp0packages"
echo.
pause
