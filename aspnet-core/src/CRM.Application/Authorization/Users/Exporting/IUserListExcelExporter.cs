using System.Collections.Generic;
using CRM.Authorization.Users.Dto;
using CRM.Dto;

namespace CRM.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}