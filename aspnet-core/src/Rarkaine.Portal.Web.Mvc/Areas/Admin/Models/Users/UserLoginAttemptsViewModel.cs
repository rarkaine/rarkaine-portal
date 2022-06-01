using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Users
{
    public class UserLoginAttemptsViewModel
    {
        public List<ComboboxItemDto> LoginAttemptResults { get; set; }
    }
}