#pragma checksum "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\InsertStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56579fb42ad7261d7e42a50990cd73aa238f1c46"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/InsertStudent")]
    public partial class InsertStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"color:blue\">ADD NEW RECORD BY FILLING BELOW DETAILS:</h1> \r\n<br>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-6");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\" style=\"color:lightseagreen\">Name</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "form", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\InsertStudent.razor"
                                                                student.StudentName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.StudentName = __value, student.StudentName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label for=\"Age\" class=\"control-label\" style=\"color:lightseagreen\">Age</label>\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "form", "Age");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\InsertStudent.razor"
                                                               student.StudentAge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.StudentAge = __value, student.StudentAge));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddMarkupContent(34, "<label for=\"Address\" class=\"control-label\" style=\"color:lightseagreen\">Gender</label>\r\n                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "form", "Address");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\InsertStudent.razor"
                                                                   student.StudentGender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.StudentGender = __value, student.StudentGender));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, " \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<label for=\"Address\" class=\"control-label\" style=\"color:lightseagreen\">Address</label>\r\n                ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "form", "Address");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\InsertStudent.razor"
                                                                   student.StudentAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => student.StudentAddress = __value, student.StudentAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row");
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col-md-4");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group");
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "style", "color:white;background-color:green");
            __builder.AddAttribute(67, "class", "btn-btn-primary");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\InsertStudent.razor"
                                                                                                                   InsertStudentRecord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "value", "SUBMIT DETAILS");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "style", "color:white;background-color:red");
            __builder.AddAttribute(74, "class", "btn-btn-primary");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\InsertStudent.razor"
                                                                                                                 Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Vishesh Kapoor\source\repos\BlazorAdvanceAssignment\Pages\Student Page\InsertStudent.razor"
 
    Student student = new Student();
 
   private void InsertStudentRecord() 
    {
        _student.Insert(student); 
        _navigation.NavigateTo("StudentPage");
    }
    private void Cancel()
    {
        _navigation.NavigateTo("StudentPage");
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
