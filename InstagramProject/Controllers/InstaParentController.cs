using InstagramProject.DataAccess.IRepository;
using InstagramProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InstagramProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstaParentController : ControllerBase
    {

        public IInstaParentRepo ParRef;
        public InstaParentController(IInstaParentRepo parRef)
        {
            ParRef = parRef;
        }
        [HttpPost]
        [Route("InsertName")]
        public async Task<IActionResult> InsertName(Instaparent instaparent)
        {
            try
            {
               var count=await ParRef.InsertName(instaparent);
                if(count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are not Inserted");
                }
            }
            catch(Exception e)
            {
                return BadRequest("Something went wrong "+e.Message+"Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetAllIds")]
        public async Task<IActionResult> GetAllIds()
        {
            try
            {
                var PList = await ParRef.GetAllIds();
                if (PList.Count > 0)
                {
                    return Ok(PList);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int PId)
        {
            try
            {
                var PL = await ParRef.GetById(PId);
                if (PL !=null)
                {
                    return Ok(PL);
                }
                else
                {
                    return NotFound("Records are not Available");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }


        [HttpPut]
        [Route("UpdateName")]
        public async Task<IActionResult> UpdateName(Instaparent instaparent)
        {
            try
            {
                var count = await ParRef.UpdateName(instaparent);
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
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }
        [HttpDelete]
        [Route("DeleteName")]
        public async Task<IActionResult> DeleteName(int PId)
        {
            try
            {
                var count = await ParRef.DeleteName(PId);
                if (count > 0)
                {
                    return Ok(count);
                }
                else
                {
                    return NotFound("Records are not Deleted");
                }
            }
            catch (Exception e)
            {
                return BadRequest("Something went wrong " + e.Message + "Will resolve soon");
            }
        }
    }
}
