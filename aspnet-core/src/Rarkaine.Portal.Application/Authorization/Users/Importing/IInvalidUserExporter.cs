using System.Collections.Generic;
using Rarkaine.Portal.Authorization.Users.Importing.Dto;
using Rarkaine.Portal.Dto;

namespace Rarkaine.Portal.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
