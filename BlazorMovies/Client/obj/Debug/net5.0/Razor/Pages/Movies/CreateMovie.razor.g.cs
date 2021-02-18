#pragma checksum "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc1801488629767e3486e8a0bc20f65fc2c7fa3"
// <auto-generated/>
#pragma warning disable 1591
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
#line 13 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.DTOs;

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
#line 2 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
using BlazorMovies.Client2.Repository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/create")]
    public partial class CreateMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Movie</h3>");
#nullable restore
#line 10 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
 if (NotSelectedGenres != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorMovies.Client2.Pages.Movies.MovieForm>(1);
            __builder.AddAttribute(2, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Movie>(
#nullable restore
#line 12 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
                      Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 12 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
                                            SaveMovie

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "NotSelectedGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Genre>>(
#nullable restore
#line 12 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
                                                                          NotSelectedGenres

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 13 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
       

	private Movie Movie = new Movie();

	protected async override Task OnInitializedAsync()
	{
		NotSelectedGenres = await gengeRepository.GetGenres();
	}

	private List<Genre> NotSelectedGenres;

	private async Task SaveMovie()
	{
		try
		{
			var movieId = await moviesRepository.CreateMovie(Movie);
			navigationManager.NavigateTo($"movie/{movieId}/{Movie.Title.Replace(" ", "-")}");
		}
		catch (Exception ex)
		{

		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository gengeRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591