using System;
using Abp.AutoMapper;
using Rarkaine.Portal.Sessions.Dto;

namespace Rarkaine.Portal.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}