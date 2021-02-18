#pragma checksum "D:\c# projects\BlazorMovies\BlazorMovies\Client\Shared\RenderMarkdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6a4b7682ad5bd0527530c677771485ffceb93b7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client2.Shared
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
#line 12 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

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
#line 14 "D:\c# projects\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client2.Repository;

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
#line 1 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Shared\RenderMarkdown.razor"
using Markdig;

#line default
#line hidden
#nullable disable
    public partial class RenderMarkdown : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Shared\RenderMarkdown.razor"
 if (HTMLContent != null)
{
	

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 5 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Shared\RenderMarkdown.razor"
      (MarkupString)HTMLContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 5 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Shared\RenderMarkdown.razor"
                                
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\c# projects\BlazorMovies\BlazorMovies\Client\Shared\RenderMarkdown.razor"
       
	[Parameter] public string MarkdownContent { get; set; }
	private string HTMLContent;

	protected override void OnParametersSet()
	{
		if (!string.IsNullOrEmpty(MarkdownContent))
		{
			HTMLContent = Markdown.ToHtml(MarkdownContent);
		}
		else
		{
			HTMLContent = null;
		}
	}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
