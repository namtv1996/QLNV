using Abp.Notifications;
using CRM.Dto;

namespace CRM.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}