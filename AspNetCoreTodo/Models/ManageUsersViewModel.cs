using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreTodo.Models;

public class ManageUsersViewModel
{
    public required IdentityUser[] Administrators { get; set; }

    public required IdentityUser[] Everyone { get; set;}
}
