using AzureDeployment.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzureDeployment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        this._userService = userService;
    }

    [HttpGet]
    [Route("GetAllUsers")]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok(await _userService.GetAllUsers());
    }
}
