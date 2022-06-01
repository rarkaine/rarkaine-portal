using Abp.Application.Services.Dto;

namespace Rarkaine.Portal.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}