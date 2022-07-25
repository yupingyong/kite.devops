using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components.Routing;

using Kite.DevOps.Blazor.Core;
using Kite.DevOps.Application.Contracts.Administrator.Dtos;
using Microsoft.AspNetCore.Components;


namespace Kite.DevOps.Blazor.Shared;

/// <summary>
/// 
/// </summary>
public sealed partial class MainLayout
{
    private bool UseTabSet { get; set; } = true;

    private string Theme { get; set; } = "";

    private bool IsFixedHeader { get; set; } = true;

    private bool IsFixedFooter { get; set; } = true;

    private bool IsFullSide { get; set; } = true;

    private bool ShowFooter { get; set; } = false;

    private List<MenuItem>? Menus { get; set; }

    [Inject]
    private AuthorizationServerStorage ServerStorage { get; set; }

    [Inject]
    private NavigationManager NavigationManager { get; set; }

    private AdministratorDto Administrator { get; set; }
    /// <summary>
    /// OnInitialized 方法
    /// </summary>
    protected override void OnInitialized()
    {
        base.OnInitialized();
        //如果没有登录则跳转到登录页面
        if (!ServerStorage.IsLogin())
        {
            NavigationManager.NavigateTo("/Login");
        }
        //
        Administrator = ServerStorage.GetServerStorage();
        if (Administrator == null)
        {
            NavigationManager.NavigateTo("/Login");
        }
        Menus = GetIconSideMenuItems();
    }

    private static List<MenuItem> GetIconSideMenuItems()
    {
        var menus = new List<MenuItem>
            {
               new MenuItem()
                        {
                            Text = "首页",
                            Icon = "fa fa-home",
                            Url = "/",
                            IsActive = true
                        },
               new MenuItem()
               {
                   Text ="系统设置",
                   Icon ="fa fa-gear",
                   Url = "",
                   Id = "1",
                   Items = new List<MenuItem>()
                   {
                       
                       new MenuItem()
                        {
                            Text = "账号管理",
                            Icon = "fa fa-user",
                            Url = "/Administrator"
                        }
                   }
               }
            };

        return menus;
    }
}
