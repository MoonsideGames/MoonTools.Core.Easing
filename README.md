# MoonTools.Core.Easing

[![NuGet Badge](https://buildstats.info/nuget/MoonTools.Core.Easing)](https://www.nuget.org/packages/MoonTools.Core.Easing/)
[![CircleCI](https://circleci.com/gh/MoonsideGames/MoonTools.Core.Easing.svg?style=svg)](https://circleci.com/gh/MoonsideGames/MoonTools.Core.Easing)

Easing functions for .NET Core

## Reference

https://easings.net

## Example

Use easing functions to transform time values and get fancy animations along paths.

```cs
using MoonTools.Core.Easing;

// Transform a normalized time value.
Easing.InQuad(0.75f); // => 0.5625f

// Transform a time value within a time range.
Easing.InOutSine(3.5, 2, 6); // => 3.2346331352698

// Move within an arbitrary number range based on time.
Easing.OutQuart(2, 10, 100, 4); // => 103.75
```

## Additional Info

Use this library with [MoonTools.Core.Curve](https://github.com/MoonsideGames/MoonTools.Core.Curve) for some nicely animated Bezier curves!