using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NotificationApi.DBModels;
using NotificationApi.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace NotificationApi.Repository
{
    public class INotificationServiceImpl : INotificationService
    {
        private readonly notificationContext _context;

        public INotificationServiceImpl(notificationContext context) {
            this._context = context;

        }

     

        public async Task<List<UserMaster>> GetAllUsers()
        {
            return await _context.UserMasters.ToListAsync();
        }

        public async Task<List<PopMaster>> GetAllPopMaster()
        {
            return await _context.PopMasters.ToListAsync();
        }

  

        public async Task<List<NotificationDetail>> GetNotificationDetailsById(int? Id)
        {
            List<NotificationDetail> notificationDetailsList = new List<NotificationDetail>();
            try
            {
                notificationDetailsList = await _context.NotificationDetails.Where(nd => nd.NotificationMasterId == Id).ToListAsync();
                return notificationDetailsList;
            }catch(Exception e)
            {
                throw;
            }    
        }

        public async Task<List<NotificationMaster>> GetNotificationMaster()
        {
            return await _context.NotificationMasters.ToListAsync();
        }

        public async Task<bool> SaveNotificationDetails(NotificationDetail notificationDetail)
        {
            int result = 0;

            try
            {
                await _context.AddAsync(notificationDetail); 
               result =  await _context.SaveChangesAsync();
            }catch(Exception e)
            {
                throw;
            }
            return result > 0;
        }

        public async  Task<Dictionary<bool,int?>> SaveNotificationMaster(NotificationMaster notificationMaster)
        {
            Dictionary<bool, int?> resultDictionary = new Dictionary<bool, int?>();
            try
            {
                await _context.AddAsync(notificationMaster);
               int result = await _context.SaveChangesAsync();
               if(result > 0)
                {
                    resultDictionary.Add(true, notificationMaster.NotificationMasterId);
                }
                else
                {
                    resultDictionary.Add(false, null);
                }
            }catch (Exception e)
            {
                throw;
            }
         
            return resultDictionary; 
        }

        public async Task<List<UserMaster>> GetUserByPopId(string id)
        {
            List<UserMaster> userPopMasters = new List<UserMaster>();
           
            try
            {
                userPopMasters = await _context.UserMasters.Include(p => p.Pop).Where(u => u.Pop.Popid.Equals(id)).ToListAsync();
            }
            catch(Exception e)
            {
                throw;
            }
            return userPopMasters;
        }
    }
}
