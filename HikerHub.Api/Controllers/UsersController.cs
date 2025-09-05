using HikerHub.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace HikerHub.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController(AppDbContext context) : ControllerBase
{
    // [HttpGet]
    
}