#pragma checksum "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\StudentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0254914aa1c6e124d14d4a8136d6f59df49ab097"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdvanceAssignment.Pages.Student_Page
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/studentpage")]
    public partial class StudentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color:blue\">TOTAL REGISTERED STUDENTS</h3>\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<h1 style=\"color:mediumvioletred\">For new Record Click Below</h1> \r\n<br>\r\n");
            __builder.AddMarkupContent(2, "<div>\r\n    <a class=\"oi-account-login\" href=\"insertstudent\"> \r\n        Create a new Record\r\n    </a>\r\n</div>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-deck");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 16 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\StudentPage.razor"
             foreach (var item in stdlist)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "m-3");
            __builder.AddAttribute(15, "style", "min-width:18rem; max-width:30.5%");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-header");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "h3");
            __builder.AddAttribute(21, "style", "color:palevioletred");
            __builder.AddContent(22, 
#nullable restore
#line 20 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\StudentPage.razor"
                                                         item.StudentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card-body");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "h5");
            __builder.AddAttribute(29, "style", "color:orangered");
            __builder.AddContent(30, 
#nullable restore
#line 23 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\StudentPage.razor"
                                                     item.StudentAge

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "h5");
            __builder.AddAttribute(33, "style", "color:orangered");
            __builder.AddContent(34, 
#nullable restore
#line 24 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\StudentPage.razor"
                                                     item.StudentGender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "h5");
            __builder.AddAttribute(37, "style", "color:orangered");
            __builder.AddContent(38, 
#nullable restore
#line 25 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\StudentPage.razor"
                                                     item.StudentAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        <br>\r\n                        ");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "href", "UpdateStudent/" + (
#nullable restore
#line 27 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\StudentPage.razor"
                                                                 item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "\r\n                            <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span> Update Details\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "class", "nav-link");
            __builder.AddAttribute(47, "href", "DeleteStudent/" + (
#nullable restore
#line 30 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\StudentPage.razor"
                                                                 item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "\r\n                            <span class=\"oi oi-trash\" aria-hidden=\"true\"></span> Delete Your Record\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 36 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\StudentPage.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\StudentPage.razor"
       
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
