#pragma checksum "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\Pages\AdminModule.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c162a2d60e5db5bced101c28fc4f29ceb1ffeb2d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAdvanceAssignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using BlazorAdvanceAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using BlazorAdvanceAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using BlazorAdvanceAssignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using BlazorAdvanceAssignment.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\_Imports.razor"
using BlazorAdvanceAssignment.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adminmodule")]
    public partial class AdminModule : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Vishesh Kapoor\Desktop\BlazorAssignment\BlazorAdvanceAssignment\Pages\AdminModule.razor"
       
    List<Student> stdlist;
    protected override async Task OnInitializedAsync()
    {
        stdlist = _student.GetStudents();

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService _stu { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudent _student { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INavbar _navbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigation { get; set; }
    }
}
#pragma warning restore 1591
