using NotificationApi.DBModels;
using NotificationApi.Models;

namespace NotificationApi.Repository
{
    public interface INotificationService
    {

        Task<Dictionary<bool,int?>> SaveNotificationMaster(NotificationMaster notificationMaster);

        Task<bool> SaveNotificationDetails(NotificationDetail notificationDetail);


        Task<List<NotificationMaster>> GetNotificationMaster();

        Task<List<NotificationDetail>> GetNotificationDetailsById(int? Id);

        Task<List<UserMaster>> GetAllUsers();
        Task<List<PopMaster>> GetAllPopMaster();

        Task<List<UserMaster>> GetUserByPopId(string id);
    }
}
