#pragma checksum "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\AdminModule.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c162a2d60e5db5bced101c28fc4f29ceb1ffeb2d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdvanceAssignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using BlazorAdvanceAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using BlazorAdvanceAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using BlazorAdvanceAssignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
using BlazorAdvanceAssignment.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\_Imports.razor"
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
            __builder.AddMarkupContent(0, "<h3 style=\"color:blue\">Admin Module</h3>\r\n<br> \r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<h2 style=\"color:gold\">Total Registerd Students</h2>\r\n       ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-bordered");
            __builder.AddMarkupContent(10, "\r\n           ");
            __builder.AddMarkupContent(11, "<tr>\r\n               <th>Id</th>\r\n               <th>Name</th>\r\n               <th>Age</th>\r\n               <th>Gender</th>\r\n               <th>Address</th>\r\n           </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\AdminModule.razor"
            foreach(var item in stdlist)
           {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "       ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n           ");
            __builder.OpenElement(15, "th");
            __builder.AddContent(16, 
#nullable restore
#line 18 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\AdminModule.razor"
                item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n           ");
            __builder.OpenElement(18, "th");
            __builder.AddContent(19, 
#nullable restore
#line 19 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\AdminModule.razor"
                item.StudentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n           ");
            __builder.OpenElement(21, "th");
            __builder.AddContent(22, 
#nullable restore
#line 20 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\AdminModule.razor"
                item.StudentAge

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n           ");
            __builder.OpenElement(24, "th");
            __builder.AddContent(25, 
#nullable restore
#line 21 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\AdminModule.razor"
                item.StudentGender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n           ");
            __builder.OpenElement(27, "th");
            __builder.AddContent(28, 
#nullable restore
#line 22 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\AdminModule.razor"
                item.StudentAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, " \r\n       ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 24 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\AdminModule.razor"
           }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "       ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\AdminModule.razor"
       
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
