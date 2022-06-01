using System.Collections.Generic;
using Rarkaine.Portal.Authorization.Users.Dto;
using Rarkaine.Portal.Dto;

namespace Rarkaine.Portal.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}