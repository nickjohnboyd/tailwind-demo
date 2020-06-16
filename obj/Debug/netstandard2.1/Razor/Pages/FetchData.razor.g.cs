#pragma checksum "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e8ac2d6f4c932e5b24ae0364a75324efb2ff4b5"
// <auto-generated/>
#pragma warning disable 1591
namespace tailwind_demo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/_Imports.razor"
using tailwind_demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/_Imports.razor"
using tailwind_demo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-4xl font-medium\">Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n");
#nullable restore
#line 8 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table-fixed w-full mt-3");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, @"<thead>
            <tr class=""border-t-2"">
                <th class=""w-1/4 text-left py-3 px-4"">Date</th>
                <th class=""w-1/4 text-left py-3 px-4"">Temp. (C)</th>
                <th class=""w-1/4 text-left py-3 px-4"">Temp. (F)</th>
                <th class=""w-1/4 text-left py-3 px-4"">Summary</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 24 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddAttribute(13, "class", "border-t-2");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "class", "py-3 px-4");
            __builder.AddContent(17, 
#nullable restore
#line 27 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor"
                                           forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "class", "py-3 px-4");
            __builder.AddContent(21, 
#nullable restore
#line 28 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor"
                                           forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "class", "py-3 px-4");
            __builder.AddContent(25, 
#nullable restore
#line 29 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor"
                                           forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "class", "py-3 px-4");
            __builder.AddContent(29, 
#nullable restore
#line 30 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor"
                                           forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 32 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 35 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/Users/nickboyd/dev/streetcred/asp.net/blazor/tailwind-demo/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
