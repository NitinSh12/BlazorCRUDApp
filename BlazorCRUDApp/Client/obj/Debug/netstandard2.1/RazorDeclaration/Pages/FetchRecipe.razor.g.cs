#pragma checksum "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\Pages\FetchRecipe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f5d5640479de930b38ce7e8e7f0dffecca4a82"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCRUDApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\_Imports.razor"
using BlazorCRUDApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\_Imports.razor"
using BlazorCRUDApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\Pages\FetchRecipe.razor"
using BlazorCRUDApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchrecipe")]
    public partial class FetchRecipe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\Pages\FetchRecipe.razor"
            
    Recipe[] recipes;
    protected override async Task OnInitializedAsync()
    {
        recipes = await Http.GetJsonAsync<Recipe[]>("api/Recipe/recipes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
