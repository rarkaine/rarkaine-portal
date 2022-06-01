using System;
using Abp.Notifications;
using Rarkaine.Portal.Dto;

namespace Rarkaine.Portal.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}