@echo off

set outputDir="%~dp0packages"

if not exist %outputDir% md %outputDir%

echo -------------------------------------------
echo Building randomColorSharped WPF package...
echo -------------------------------------------
nuget pack "%~dp0..\RandomColor\RandomColorGenerator.WPF.csproj" -build -Prop Configuration=Release -OutputDirectory %outputDir% -Symbols
echo.

echo -------------------------------------------
echo Building randomColorSharped Forms package...
echo -------------------------------------------
nuget pack "%~dp0..\RandomColor\RandomColorGenerator.Forms.csproj" -build -Prop Configuration=Release -OutputDirectory %outputDir% -Symbols
echo.

pause