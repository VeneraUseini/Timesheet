#pragma checksum "C:\Users\User\Desktop\Blazor\Timesheet\Shared\LoginControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61fa664e0fc583dfef7c59313109905c7bf688b5"
// <auto-generated/>
#pragma warning disable 1591
namespace Timesheet.Shared
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
#line 2 "C:\Users\User\Desktop\Blazor\Timesheet\Shared\LoginControl.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/loginControl")]
    public partial class LoginControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "b");
                __builder2.AddContent(4, "Hello, ");
                __builder2.AddContent(5, 
#nullable restore
#line 5 "C:\Users\User\Desktop\Blazor\Timesheet\Shared\LoginControl.razor"
                   context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(6, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<a class=\"ml-md-auto btn btn-primary\" href=\"/logout?returnUrl=/\" target=\"_top\">Logout</a>\r\n    ");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "type", "text");
                __builder2.AddAttribute(13, "placeholder", "User Name");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\User\Desktop\Blazor\Timesheet\Shared\LoginControl.razor"
                       Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Username = __value, Username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        &nbsp;&nbsp;\r\n        ");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "type", "password");
                __builder2.AddAttribute(19, "placeholder", "Password");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\User\Desktop\Blazor\Timesheet\Shared\LoginControl.razor"
                       Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "a");
                __builder2.AddAttribute(24, "class", "ml-md-auto btn btn-primary");
                __builder2.AddAttribute(25, "href", "/login?paramUsername=" + (
#nullable restore
#line 19 "C:\Users\User\Desktop\Blazor\Timesheet\Shared\LoginControl.razor"
                                       encode(@Username)

#line default
#line hidden
#nullable disable
                ) + "&paramPassword=" + (
#nullable restore
#line 19 "C:\Users\User\Desktop\Blazor\Timesheet\Shared\LoginControl.razor"
                                                                        encode(@Password)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "target", "_top");
                __builder2.AddContent(27, "Login");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\User\Desktop\Blazor\Timesheet\Shared\LoginControl.razor"
       
    string Username = "";
    string Password = "";
    private string encode(string param)
    {
        return HttpUtility.UrlEncode(param);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591