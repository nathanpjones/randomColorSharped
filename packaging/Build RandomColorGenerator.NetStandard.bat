@echo off
echo ---------------------------------------------------------
echo Building RandomColorGenerator.NetStandard package...
echo ---------------------------------------------------------
if not exist "%~dp0packages" md "%~dp0packages"
dotnet pack "%~dp0..\RandomColorGenerator.NetStandard\RandomColorGenerator.NetStandard.csproj" --configuration Release -p:GenerateDocumentationFile=true --include-symbols -p:SymbolPackageFormat=snupkg --output "%~dp0packages"
echo.
pause
