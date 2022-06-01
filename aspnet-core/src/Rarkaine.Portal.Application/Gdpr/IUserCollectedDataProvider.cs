using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Rarkaine.Portal.Dto;

namespace Rarkaine.Portal.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
