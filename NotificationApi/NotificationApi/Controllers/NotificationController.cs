using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationApi.DBModels;
using NotificationApi.DTO;
using NotificationApi.Models;
using NotificationApi.Repository;
using System.Diagnostics;

namespace NotificationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _service;

        public NotificationController(INotificationService service)
        {
            this._service = service;
        }

    
        // Get All Notification Master Details
        [HttpGet("getNotificationMaster")]
        public async Task<ActionResult<List<NotificationMaster>>> GetNotificationMaster(){

            List<NotificationMaster> notificationMasters = await _service.GetNotificationMaster();
            if(notificationMasters.Count < 1)
            {
                return NotFound("No Data Found");
            }
            return Ok(notificationMasters);
        }

        //Get All Pop Address

        [HttpGet("getUserByPopArea")]
        public async Task<ActionResult<List<UserMaster>>> GetUserByPopAddress()
        {

            List<UserMaster> userMasterPops = await _service.GetAllUsers();
            if (userMasterPops.Count < 1)
            {
                return NotFound("No Data Found");
            }
            return Ok(userMasterPops);
        }

        //Get al Pop Master
        [HttpGet("getAllPopMaster")]
        public async Task<ActionResult<List<PopMaster>>> GetAllPopMaster()
        {

            List<PopMaster> popMaster = await _service.GetAllPopMaster();
            if (popMaster.Count < 1)
            {
                return NotFound("No Data Found");
            }
            return Ok(popMaster);
        }

        //Get Notification Details By Id

        [HttpGet("getNotificationDetails/{id}")]

        public async Task<ActionResult<List<NotificationDetail>>> GetNotificationDetailsById(int? id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest("Please Provide Id");
                }
                List<NotificationDetail> notificationDetails = await _service.GetNotificationDetailsById(id);
                if (notificationDetails.Count == 0)
                {
                    return NotFound("No Data Found");
                }
                return Ok(notificationDetails);
            }catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        //Get User By Pop Id

        [HttpGet("getUserByPop/{id}")]

        public async Task<ActionResult<List<UserMaster>>> GetUsersByPopId(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Please provide id");
            }
            try
            {
                List<UserMaster> userMasterPopList = await _service.GetUserByPopId(id);

                if(userMasterPopList.Count == 0)
                {
                    return NotFound("No record found");
                }

                return userMasterPopList;
            }catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // Add Notification Master
        [HttpPost("AddNotificationMaster")]
        public async Task<IActionResult> SaveNotificationMaster([FromBody] NotificationMaster notificationMaster)
        {
            try
            {
                if (notificationMaster == null)
                {
                    return BadRequest("Null request Body");
                }
                Dictionary<bool,int?> result = await _service.SaveNotificationMaster(notificationMaster);
                if (result.ContainsKey(true))
                {
                    return StatusCode(201,result);
                }
                else
                {
                    return StatusCode(500, "Internal Server Error");
                }
            }catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        //Add Notification Details


        /*  public async Task<IActionResult> SaveNotificationDetails([FromBody] List<NotificationDetail> notificationDetail)
          {
              try
              {
                  List<bool> isSuccessList = new List<bool>();
                  if(notificationDetail == null)
                  {
                      return BadRequest("Body not Found");
                  }
                  foreach (var nd in notificationDetail)
                  {
                      bool result = await _service.SaveNotificationDetails(nd);
                      isSuccessList.Add(result);
                  }
                  if (isSuccessList.Contains(true))
                  {
                      return StatusCode(201, new { SuccessCount = isSuccessList.Count(r => r), FailureCount = isSuccessList.Count(r => !r), Results = isSuccessList });
                  }
                  else
                  {
                      return StatusCode(500, "Internal Server Error");
                  }
              }
              catch(Exception e)
              {
                  return StatusCode(500, e.Message);
              }
          }*/
        //[FromBody] NotificationDetail notificationDetail
        
        [HttpPost("addNotificationDetails")]
        public async Task<IActionResult> SaveNotificationDetails([FromBody] List<NotificationDetailDTO> notificationDetail)
        {
            try
            {
                List<bool> isSuccessList = new List<bool>();
               
                if (notificationDetail == null)
                {
                    return BadRequest("Body not Found");
                }
                foreach (var nd in notificationDetail)
                {
                    NotificationDetail notificationObj = new NotificationDetail
                    {
                        WhatsAppNumber = nd.whatsAppNumber,
                        InvalidWhatsappNumbers = nd.invalidWhatsappNumbers,
                        NotificationMasterId = (int)nd.NotificationMasterId,
                        Error = nd.error,
                        Status = nd.status,
                        Date = nd.Date

                    };

                   bool result = await _service.SaveNotificationDetails(notificationObj);
                    isSuccessList.Add(result);
                }
                if (isSuccessList.Contains(true))
                {
                    return StatusCode(201, new { SuccessCount = isSuccessList.Count(r => r), FailureCount = isSuccessList.Count(r => !r), Results = isSuccessList });
                }
                else
                {
                    return StatusCode(500, "Internal Server Error");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
