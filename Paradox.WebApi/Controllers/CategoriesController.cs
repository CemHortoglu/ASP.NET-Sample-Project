using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Paradox.Entities.Dtos;
using Paradox.Services.Abstract;
using Paradox.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paradox.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;

        public CategoriesController(ICategoryService categoryService, IUserService userService)
        {
            _categoryService = categoryService;
            _userService = userService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllAsync()
        {

            var result = await _categoryService.GetAll();

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("get")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var result = await _categoryService.Get(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getuser")]
        public async Task<IActionResult> GetUserAsync(int id)
        {
            var result = await _userService.GetClimeWithUserId(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

    }
}
