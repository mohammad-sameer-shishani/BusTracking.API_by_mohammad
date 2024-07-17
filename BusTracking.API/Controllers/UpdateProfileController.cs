﻿using BusTracking.Core.DTO;
using BusTracking.Core.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusTracking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateProfileController : ControllerBase
    {
        private readonly IUpdateProfileService _updateProfileService;

        public UpdateProfileController(IUpdateProfileService updateProfileService)
        {
            _updateProfileService = updateProfileService;
        }

        [HttpPost]                                      //successfully working
        public async Task UpdateProfile([FromBody]UpdateProfile profile) 
        {
            await _updateProfileService.UpdateProfile(profile);
        }
    }
}
