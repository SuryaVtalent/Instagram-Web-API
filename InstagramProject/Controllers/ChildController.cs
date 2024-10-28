using InstagramProject.DataAccess.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using InstagramProject.DataAccess.Repository;
using InstagramProject.Models;

namespace InstagramProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        public IInstachildRepo signRef;
        public ChildController(IInstachildRepo signRef)
        {
            this.signRef = signRef;
        }

        [HttpPost]
        [Route("InsertNames")]
        public async Task<IActionResult> InsertNames(Instachild signUp)
        {
            try
            {
                var count = await signRef.InsertNames(signUp);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are not Inserted");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("AllSignDetails")]
        public async Task<IActionResult> AllSignDetails()
        {
            try
            {
                var SignList = await signRef.AllSignDetails();
                if (SignList.Count > 0)
                {
                    return Ok(SignList);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetSignUpById")]
        public async Task<IActionResult> GetSignUpById(int InstagramId)
        {
            try
            {
                var Sign = await signRef.GetSignUpById(InstagramId);
                if (Sign != null)
                {
                    return Ok(Sign);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetEmailandPassword")]
        public async Task<IActionResult> GetEmailandPassword(string Email, string Password)
        {
            try
            {
                var SignList = await signRef.GetEmailandPassword(Email, Password);

                return Ok(SignList);
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }



        [HttpPut]
        [Route("UpdateNames")]
        public async Task<IActionResult> UpdateNames(Instachild signUp)
        {
            try
            {
                var count = await signRef.UpdateNames(signUp);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are not Updated");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }

        [HttpDelete]
        [Route("DeleteNames")]
        public async Task<IActionResult> DeleteNames(int InstagramId)
        {
            try
            {
                var count = await signRef.DeleteNames(InstagramId);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are not Inserted");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong" + e.Message + "Will resolve soon");
            }
        }
    }
}
