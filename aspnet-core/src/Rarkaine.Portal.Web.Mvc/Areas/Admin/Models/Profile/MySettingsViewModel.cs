using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Rarkaine.Portal.Authorization.Users.Profile.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Profile
{
    [AutoMapFrom(typeof(CurrentUserProfileEditDto))]
    public class MySettingsViewModel : CurrentUserProfileEditDto
    {
        public List<ComboboxItemDto> TimezoneItems { get; set; }

        public bool SmsVerificationEnabled { get; set; }

        public bool CanChangeUserName => UserName != AbpUserBase.AdminUserName;

        public string Code { get; set; }
    }
}