randomColorSharped
==================

This is a port to c# (.NET Standard 2.0 and .NET Framework 4.0) of 
[randomColor](https://github.com/davidmerfield/randomColor/), David Merfield's
javascript random color generator. This was ported by 
[Nathan Jones](http://www.nathanpjones.com/) so that users of the .NET family of
languages could enjoy these attractive colors.

I saw this project linked on [Scott Hanselman's](http://www.hanselman.com/) 
excellent [Newsletter of Wonderful Things](http://www.hanselman.com/newsletter/)
around the same time a coworker was creating an ad hoc visualization app. As we
watched the data appear on screen, we had to squint as some of the colors were
very difficult to make out against the background. This should make things
easier to see and will hopefully help others as well.

A simple demo in WPF is included so you can play with the various combinations.

![Demo App Screenshot](./RandomColorDemoScreenshot.png?raw=true)

Getting a single color is a simple matter.

```csharp
using RandomColorGenerator;
...
var color = RandomColor.GetColor(ColorScheme.Random, Luminosity.Bright);
```

Or you can generate multiple colors in a single go.

```csharp
var colors = RandomColor.GetColors(ColorScheme.Red, Luminosity.Light, 25);
```

# Installing

randomColorSharped is made available as several NuGet packages depending on your needs.

#### For .NET Standard

[randomColorSharped.NetStandard](https://www.nuget.org/packages/randomColorSharped.Forms/) (uses `System.Drawing` added in [.NET Standard 2.0](https://apisof.net/catalog/System.Drawing.Color))

```batch
Install-Package randomColorSharped.NetStandard
```

#### For WinForms on .NET Framework

[randomColorSharped.Forms](https://www.nuget.org/packages/randomColorSharped.Forms/) (uses `System.Drawing`)

*NOTE: You should use the NetStandard package above if you're using a version of
.NET Framework that supports it. This Forms package may be deprecated in future.*

```batch
Install-Package randomColorSharped.Forms
```

#### For WPF on .NET Framework
[randomColorSharped.WPF](https://www.nuget.org/packages/randomColorSharped.WPF/) (uses `System.Windows`)

```batch
Install-Package randomColorSharped.WPF
```
