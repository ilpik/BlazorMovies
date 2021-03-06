// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Client2.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client2.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
using BlazorMovies.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
using BlazorMovies.Client2.Repository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}/{MovieName}")]
    public partial class DetailsMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
       
	[Parameter] public int MovieId { get; set; }
	[Parameter] public string MovieName { get; set; }
	private RenderFragment<Genre> linkGenre = (genre) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "a");
            __builder2.AddAttribute(1, "href", "movies/search?genreId=" + (
#nullable restore
#line 57 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                         genre.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(2, 
#nullable restore
#line 57 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                                    genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 57 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                                                  ;
DetailsMovieDTO model;


protected async override Task OnInitializedAsync()
{
model = await moviesRepository.GetDetailsMovieDTO(MovieId);
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
    }
}
#pragma warning restore 1591
