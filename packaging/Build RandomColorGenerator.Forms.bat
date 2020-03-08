@echo off
echo ---------------------------------------------------------
echo Building RandomColorGenerator.Forms package...
echo ---------------------------------------------------------
if not exist "%~dp0packages" md "%~dp0packages"
dotnet pack "%~dp0..\RandomColorGenerator.Forms\RandomColorGenerator.Forms.csproj" --configuration Release -p:GenerateDocumentationFile=true --include-symbols -p:SymbolPackageFormat=snupkg --output "%~dp0packages"
echo.
pause
