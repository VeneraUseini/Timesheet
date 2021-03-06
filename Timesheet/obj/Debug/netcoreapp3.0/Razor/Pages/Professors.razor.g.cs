#pragma checksum "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54566d94de15f827930b9b30a121dfa00a2ab6e6"
// <auto-generated/>
#pragma warning disable 1591
namespace Timesheet.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\Blazor\Timesheet\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Blazor\Timesheet\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Blazor\Timesheet\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Blazor\Timesheet\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Blazor\Timesheet\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Blazor\Timesheet\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Blazor\Timesheet\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Blazor\Timesheet\_Imports.razor"
using Timesheet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Blazor\Timesheet\_Imports.razor"
using Timesheet.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
using Timesheet.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/professors")]
    public partial class Professors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Professors</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates managing professors data</p>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
 if (professors == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                       Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddContent(8, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>First Name</th>\r\n                <th>Last Name</th>\r\n                <th>Faculty</th>\r\n                <th>Email</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 28 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
             foreach (var item in professors)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "tr");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                            () => Show(item.ProfessorId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 31 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                     item.ProfessorId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 33 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 34 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                     item.Faculty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 35 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                     item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 37 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 40 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 42 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
 if (professors != null && mode == MODE.Add) //insert
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "placeholder", "First Name");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                                            firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    <br>\r\n    ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "placeholder", "Last Name");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                                           lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    <br>\r\n    ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "placeholder", "Faculty");
            __builder.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                                         faculty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => faculty = __value, faculty));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    <br>\r\n    ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "placeholder", "Email");
            __builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                                       email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    <br>\r\n    ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                       Insert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "class", "btn btn-warning");
            __builder.AddContent(64, "Insert");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 53 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 55 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
 if (professors != null && mode == MODE.EditDelete) // Update & Delete form
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "    ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "hidden");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                                 professorId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => professorId = __value, professorId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    <br>\r\n    ");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "placeholder", "First Name");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                                            firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    <br>\r\n    ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "placeholder", "Last Name");
            __builder.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                                           lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    <br>\r\n    ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "placeholder", "Faculty");
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                                         faculty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => faculty = __value, faculty));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    <br>\r\n    ");
            __builder.OpenElement(88, "input");
            __builder.AddAttribute(89, "placeholder", "Email");
            __builder.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                                       email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n    <br>\r\n    ");
            __builder.OpenElement(93, "button");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                       Update

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "class", "btn btn-primary");
            __builder.AddContent(96, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.AddMarkupContent(98, "<span>&nbsp;&nbsp;&nbsp;&nbsp;</span>\r\n    ");
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
                       Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "class", "btn btn-danger");
            __builder.AddContent(102, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 70 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\User\Desktop\Blazor\Timesheet\Pages\Professors.razor"
            
    List<Professor> professors;

    string professorId;
    string firstName;
    string lastName;
    string faculty;
    string email;
    private enum MODE { None, Add, EditDelete };
    MODE mode = MODE.None;
    Professor professor;

    protected override async Task OnInitializedAsync()
    {
        await load();
    }
    protected async Task load()
    {
        professors = await professorService.GetProfessorsAsync();
    }

    protected void ClearFields()
    {
        professorId = string.Empty;
        firstName = string.Empty;
        lastName = string.Empty;
        faculty = string.Empty;
        email = string.Empty;
    }

    protected async Task Insert()
    {
        Professor p = new Professor()
        {
            ProfessorId = Guid.NewGuid().ToString(),
            FirstName = firstName,
            LastName = lastName,
            Faculty = faculty,
            Email = email
        };

        await professorService.InsertProfessorAsync(p);
        ClearFields();
        await load();
    }

    protected void Add()
    {
        ClearFields();
        mode = MODE.Add;
    }

    protected async Task Update()
    {
        Professor p = new Professor()
        {
            ProfessorId = professorId,
            FirstName = firstName,
            LastName = lastName,
            Faculty = faculty,
            Email = email
        };
        await professorService.UpdateProfessorAsync(professorId, p);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Delete()
    {
        await professorService.DeleteProfessorAsync(professorId);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Show(string id)
    {
        professor = await professorService.GetProfessorByIdAsync(id);
        professorId = professor.ProfessorId;
        firstName = professor.FirstName;
        lastName = professor.LastName;
        faculty = professor.Faculty;
        email = professor.Email;
        mode = MODE.EditDelete;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Timesheet.Data.ProfessorService professorService { get; set; }
    }
}
#pragma warning restore 1591
