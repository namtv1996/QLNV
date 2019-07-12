using System.Collections.Generic;
using MvvmHelpers;
using CRM.Models.NavigationMenu;

namespace CRM.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}