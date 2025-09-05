using Microsoft.AspNetCore.Identity;

namespace HikerHub.Core.Entities;

public class User : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? ProfilePictureUrl { get; set; }
}