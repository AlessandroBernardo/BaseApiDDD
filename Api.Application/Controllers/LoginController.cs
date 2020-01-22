using Api.Domain.Entities;
using Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]

    public class LoginController : ControllerBase
    {
        [HttpPost]
        public async Task<object> Login([FromBody] UserEntity userEntity, [FromServices] ILoginService service)
        {

            dynamic result = null;

            try
            {
                return !ModelState.IsValid ? BadRequest(ModelState) : userEntity == null ? BadRequest() : result = await service.FindByLogin(userEntity) != null ? Ok(result) : NotFound();

            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }





            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            //if(userEntity == null)
            //{
            //    return BadRequest();
            //}
            //try
            //{
            //    var result = await service.FindByLogin(userEntity);
            //    if(result != null)
            //    {
            //        return Ok(result);
            //    }
            //    else
            //    {
            //        return NotFound();
            //    }

            //}
            //catch (ArgumentException e)
            //{

            //    return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            //}
        }

    }
}
