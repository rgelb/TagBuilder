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