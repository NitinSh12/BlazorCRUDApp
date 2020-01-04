#pragma checksum "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\Pages\DeleteRecipe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "058fad0b1aa2939600889fc398e8eac8426e7042"
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
#line 1 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\Pages\DeleteRecipe.razor"
using BlazorCRUDApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete/{recipeId}")]
    public partial class DeleteRecipe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\nitin\source\repos\BlazorCrudApp\BlazorCRUDApp\Client\Pages\DeleteRecipe.razor"
            
    [Parameter]
    public string recipeId { get; set; }
    Recipe recipe = new Recipe();
    protected override async Task OnInitializedAsync()
    {
        recipe = await Http.GetJsonAsync<Recipe>
        ("/api/Recipe/detail/" + Convert.ToInt32(recipeId));
    }
    protected async Task Delete()
    {
        await Http.DeleteAsync("api/Recipe/delete/" + Convert.ToInt32(recipeId));
        Navigation.NavigateTo("/fetchrecipe");
    }
    void cancel()
    {
        Navigation.NavigateTo("/fetchrecipe");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
