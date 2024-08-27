# HTML Tag Builder

A wrapper class that exposes all CSS properties and rules as methods.

## How to use

Step 1.  Copy the TagBuilder.cs into your project
Step 2.  Call it.

```csharp
using System;
using HtmlHelpers;

var builder = new TagBuilder("div", "Not visible to other parties");

string html = builder
    .BackgroundColor("yellow")
    .BorderRadius("10px")
    .PaddingLeft("10px")
    .PaddingRight("10px")
    .Color("darkorange")
    .FontSize("smaller")
    .Display("inline-flex")
    .AlignItems("center")
    .JustifyContent("center")
    .Build();

Console.WriteLine(html);
```

Output:

```html
<div style="background-color:yellow;border-radius:10px;padding-left:10px;padding-right:10px;color:darkorange;font-size:smaller;display:inline-flex;align-items:center;justify-content:center;">Not visible to other parties</div>
```

## Try it out
Start the Developer Command Prompt for VS2022, navigate to the repo directory, then compile the example:

`csc Example.cs TagBuilder.cs`

It results in Example.exe - run it.