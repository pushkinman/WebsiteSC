#pragma checksum "D:\VR AR Lab\CC\WebsiteSC\Blazor_0.1\Blazor_0.1\Shared\MainLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c85aa8da5cdbad06d3805da62048f9ad06c72bfc"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_0._1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Blazor_0._1;
    using Blazor_0._1.Shared;
    public class MainLayout : BlazorLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 25 "D:\VR AR Lab\CC\WebsiteSC\Blazor_0.1\Blazor_0.1\Shared\MainLayout.cshtml"
            
    protected override async Task OnInitAsync()
    {
        await localizator.Load("en-en");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Blazor_0._1.Localization.Localizator localizator { get; set; }
    }
}
#pragma warning restore 1591
