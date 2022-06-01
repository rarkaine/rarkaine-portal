using System.Collections.Generic;
using Rarkaine.Portal.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Rarkaine.Portal.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
